using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("KillMe", 5);
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            Debug.Log("Hit Detected");
            ScoreManager.instance.counter++;
            ScoreManager.instance.UpdatekillCounter();
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
        }
    }
}
