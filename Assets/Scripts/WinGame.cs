using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winText;
    
    private void OnTriggerEnter(Collider other)
    {
        winText.SetActive(true);
    }
}
