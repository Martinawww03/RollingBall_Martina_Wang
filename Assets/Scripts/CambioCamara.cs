using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    [SerializeField]GameObject camAApagar;
    [SerializeField]GameObject camEncender;
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
            camAApagar.SetActive(false);
            camEncender.SetActive(true);

        }
    }
}
