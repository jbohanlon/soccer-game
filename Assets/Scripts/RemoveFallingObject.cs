using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFallingObject : MonoBehaviour
{
    private float despawnPoint = -5f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= despawnPoint)
        {
            Destroy(gameObject);
        }
    }
}
