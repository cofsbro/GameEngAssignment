using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform cameraTarget;
    public Vector3 offset;
    public float h= 10f;
    public float d = 10f;
    public float a = 45f;


    // Start is called before the first frame update
    void Start()
    {
        Camhand();


    }

    // Update is called once per frame
    void Update()
    {
        Camhand();
    }

    protected virtual void Camhand()
    {
        if(!cameraTarget)
        {
            return;
        }

        Vector3 wpos = (Vector3.forward * d) + (Vector3.up * h);

        Vector3 ropos = Quaternion.AngleAxis(a, Vector3.up) * wpos;

        Vector3 flat = cameraTarget.position;
        


    }
}
