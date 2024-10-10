using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private int fuerza = 2;
    [SerializeField] private int velocity = 5;
    int puntuacion;
    [SerializeField] TMP_Text textPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerza, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(1, 0, 0).normalized * velocity * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(new Vector3(-1, 0, 0).normalized * velocity * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, -1).normalized * velocity * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, 1).normalized * velocity * Time.deltaTime);

        }  

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coleccionable"))
        {
          Destroy(other.gameObject);
            puntuacion += 1;
            textPuntuacion.text = "Score: " + puntuacion;

        }
    }


    // private void FixedUpdate()
    // {
    //   GetComponent<Rigidbody>().AddForce(Vector3.forward * 3, ForceMode.Force); 
    //     
    // }
}
