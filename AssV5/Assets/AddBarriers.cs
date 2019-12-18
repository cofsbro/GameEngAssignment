using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AddBarriers : MonoBehaviour
{

    public int targetCount = 5;
    public float radius = 10;
    public GameObject blockPrefab;
    // Start is called before the first frame update

    System.Collections.IEnumerator SpawnWalls()
    {
        yield return new WaitForSeconds(3);
        while (true)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("blocker"); 
            if (enemies.Length < targetCount)
            {
                GameObject enemy = GameObject.Instantiate(blockPrefab);
                float bx = Random.Range(-10, 10);
                float bz = Random.Range(-10, 10);
                enemy.transform.position = new Vector3
                    (bx
                    , .5f
                    , bz
                );
                //surface.buildNavMesh();
            }

            yield return new WaitForSeconds(2);
        }
    }
    void Start()
    {
        StartCoroutine(SpawnWalls());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
