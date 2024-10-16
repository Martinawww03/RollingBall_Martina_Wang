using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedPiedra : MonoBehaviour
{
    private bool inciarTimer;
    private float timer = 0;

    private void Update()
    {
         if(inciarTimer==true)
         {
            timer += 1 * Time.unscaledDeltaTime; //no afecta a tiempo
            if(timer >= 2)
            {
                Time.timeScale = 1;
            }
         }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            Time.timeScale = 0.2f;
            inciarTimer = true;
            
        }
    }
}
