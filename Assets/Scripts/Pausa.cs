using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject ObjectoMenuPausa;
    public bool pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(pausa==false)
            {
                ObjectoMenuPausa.SetActive(true);
                pausa = true;
                Time.timeScale = 0;

            }
        }
        
    }
}
