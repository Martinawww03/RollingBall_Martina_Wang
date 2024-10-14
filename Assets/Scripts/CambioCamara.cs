using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    [SerializeField]GameObject camaraA;
    [SerializeField]GameObject camaraB;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(camaraA.activeSelf)
            {
            camaraA.SetActive(false);
            camaraB.SetActive(true);

            }

        }
    }
}
