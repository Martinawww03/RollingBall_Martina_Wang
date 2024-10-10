using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo2 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float fuerza = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(new Vector3(0, 1, 0) * fuerza, ForceMode.Force);
    }
}
