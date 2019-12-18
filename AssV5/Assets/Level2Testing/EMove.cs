using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMove : MonoBehaviour
{


    Transform player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime * 1f);
        
    }
}
