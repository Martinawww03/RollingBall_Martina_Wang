using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private int fuerza = 4;
    [SerializeField] private int velocity = 2;
    int puntuacion;
    int vidas = 5;
    [SerializeField] TMP_Text textPuntuacion;
    [SerializeField] TMP_Text textVidas;
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
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coleccionable"))
        {
          Destroy(other.gameObject);
            puntuacion += 1;
            textPuntuacion.text = "Score: " + puntuacion;

        }
        if(other.gameObject.CompareTag("Trampa"))
        {
            Destroy(other.gameObject);
            vidas -= 1;
            textVidas.text = "Vidas: " + vidas;
        }
        if(other.gameObject.CompareTag("Block"))
        {
            Destroy(this.gameObject);
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
