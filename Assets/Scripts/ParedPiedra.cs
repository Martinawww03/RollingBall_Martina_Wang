using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedPiedra : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
        }
    }
}
