using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    [SerializeField] private AudioClip sonidoClip;
    [SerializeField] private AudioManager miManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            miManager.ReproducirSonido(sonidoClip);
        }
    }

}
