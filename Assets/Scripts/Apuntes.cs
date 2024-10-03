using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); //EN MAYUSCULA
        // A (h=-1), D (h=-1) , ->(h=1) , <- (h=-1)

        float v = Input.GetAxisRaw("Vertical"); // EN MAYUSCULA
        // S (v=-1), W (v=-1) , ^(v=1) , v (v=-1)

        // Debug.Log(v);

    }
}
