using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTest : MonoBehaviour
{
    public int targetCount = 10;
    public float radius = 10;
    public GameObject enemyPrefab;
    public int door;
    public float yPos = 0.5f;

    System.Collections.IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(3);

        while (true)
        {

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("NewEnemy");
            door = Random.Range(1, 6);
            if (enemies.Length < targetCount)
            {

               
                    GameObject enemy = GameObject.Instantiate(enemyPrefab);
                //Vector2 c = Random.insideUnitCircle * radius;
                enemy.transform.position = new Vector3
                    (Random.Range(20,-20)
                    , yPos
                    , -23
                );  

            }
            yield return new WaitForSeconds(2);
        }
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnEnemy());

    }

    // Update is called once per frame
    void Update()
    {

    }
}
