using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploVector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, 3, 0); //posici�n
        transform.eulerAngles = new Vector3(45, 90, 30); //rotaci�n
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
