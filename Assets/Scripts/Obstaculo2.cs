using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo2 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float fuerza = 0.5f;
    [SerializeField] private Vector3 direccionRotacion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque((direccionRotacion).normalized * fuerza, ForceMode.VelocityChange);//que no le afecta la masa
    }

    // Update is called once per frame
    void Update()
    {
    }
}
