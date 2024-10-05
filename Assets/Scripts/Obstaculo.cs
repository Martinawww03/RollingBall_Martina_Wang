using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int velocidad = 2;
    [SerializeField] private int limiteIzquierdo = -1;
    [SerializeField] private int limiteDerecho = 1;
    [SerializeField] private float timer = 0f;
    [SerializeField] private int direccion = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direccion * velocidad * Time.deltaTime, 0, 0);

        if (transform.position.x > limiteDerecho) 
        {
            direccion = -1;
        }
        else if (transform.position.x < limiteIzquierdo) 
        {
            direccion = 1;
        }
    }
}
