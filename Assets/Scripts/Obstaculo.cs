using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad = 0.5f;
    [SerializeField] int direccion;
    [SerializeField] float timer = 0f;
    bool alarmaActivada = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
     transform.Translate(1, 0, 0 * velocidad * Time.deltaTime);

        
    }
}
