using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploVector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, 3, 0); //posición
        transform.eulerAngles = new Vector3(45, 90, 30); //rotación
        //float timer=0f;
        //bool alarmaActivad= true;
        // timer += 1 * Time.deltaTime; timer se va sumando uno por segundo
        
        // if(timer>=5)
        //{
        // Debug.log("Hola");
        // timer=0;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
