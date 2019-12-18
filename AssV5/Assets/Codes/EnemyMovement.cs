using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{

    Transform player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //StartCoroutine(Chase());
    }



    /*IEnumerator Chase()
    {
    
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * 0.25f);
            transform.LookAt(player.parent);
        }
        
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * 0.25f);
        transform.LookAt(player.parent);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Hit Detected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }

        if (collision.transform.tag == "Player")
        {
            Debug.Log("Hit Detected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
    }
}
