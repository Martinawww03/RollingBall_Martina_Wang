using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedPiedra : MonoBehaviour
{
    private bool inciarTimer;
    private float timer = 0;
    [SerializeField] private Rigidbody[] rbs; //[] rigidbodyS

    private void Update()
    {
         if(inciarTimer==true)
         {
            timer += 1 * Time.unscaledDeltaTime; //no afecta a tiempo
            if(timer >= 2)
            {
                Time.timeScale = 1;

                //Recorro el array de rbs para volverles a poner gravedad
                for(int i = 0; i < rbs.Length; i++)
                {
                 rbs[i].useGravity = true;
                }
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
