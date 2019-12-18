using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
  
    public Transform cameraTarget;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position + offset, Time.deltaTime * 5.0f);
        transform.LookAt(cameraTarget.parent);
    }
}
