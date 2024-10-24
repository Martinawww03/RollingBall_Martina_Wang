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
    [SerializeField] private float distanciaRaycast;
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
            //Mira a ver si detectas suelo...
            if(DetectaSuelo()==true)
            {

             rb.AddForce(new Vector3(0, 1, 0) * fuerza, ForceMode.Impulse);

            }

        }


       //if (Input.GetKey(KeyCode.A))
       //{
       //    transform.Translate(new Vector3(1, 0, 0).normalized * velocity * Time.deltaTime);
       //
       //}
       //if (Input.GetKey(KeyCode.D))
       //{
       //    transform.Translate(new Vector3(-1, 0, 0).normalized * velocity * Time.deltaTime);
       //
       //}
       //if (Input.GetKey(KeyCode.W))
       //{
       //    transform.Translate(new Vector3(0, 0, -1).normalized * velocity * Time.deltaTime);
       //
       //}
       //if (Input.GetKey(KeyCode.S))
       //{
       //    transform.Translate(new Vector3(0, 0, 1).normalized * velocity * Time.deltaTime);
       //
       //}  

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

    private bool DetectaSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, distanciaRaycast);
        Debug.DrawRay(transform.position, Vector3.down, Color.red, 2f);
        return resultado;

        
    }



    private void FixedUpdate()
    {
        float x= Input.GetAxisRaw("Horizontal"), y = 0, z = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(x, y, z).normalized * velocity, ForceMode.Force);
        
    }
}
