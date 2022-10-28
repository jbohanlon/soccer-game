using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;    // This is what the camera should follow

    private Vector3 offset;     // This is the distance between the target and the camera

    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = target.position - offset;
    }
}
