using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
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

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            door = Random.Range(1, 6);
            if (enemies.Length < targetCount)
            {

                //north door
                if (door == 1 || door == 2)
                {
                    GameObject enemy = GameObject.Instantiate(enemyPrefab);
                    //Vector2 c = Random.insideUnitCircle * radius;
                    enemy.transform.position = new Vector3
                        (0
                        , yPos
                        , 12
                    );
                }

                //East door
                if (door == 3)
                {
                    GameObject enemy = GameObject.Instantiate(enemyPrefab);
                    //Vector2 c = Random.insideUnitCircle * radius;
                    enemy.transform.position = new Vector3
                        (12
                        , yPos
                        , 0
                    );
                }

                // West
                if (door == 4)
                {
                    GameObject enemy = GameObject.Instantiate(enemyPrefab);
                    //Vector2 c = Random.insideUnitCircle * radius;
                    enemy.transform.position = new Vector3
                        (-12
                        , yPos
                        , 0
                    );
                }

                //South Door
                if(door == 5 || door == 6)
                {
                    GameObject enemy = GameObject.Instantiate(enemyPrefab);
                    //Vector2 c = Random.insideUnitCircle * radius;
                    enemy.transform.position = new Vector3
                        (0
                        , yPos
                        , -12
                    );
                }

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
