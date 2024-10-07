using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 obstaculo;
    [SerializeField] int velocity = 2;
    float timer = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(obstaculo * velocity * Time.deltaTime, Space.World);
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            obstaculo = obstaculo * -1;
            timer = 0;
        }
        
    }
}
