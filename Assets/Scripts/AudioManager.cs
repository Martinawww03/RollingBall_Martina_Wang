using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
    // AudioManager= yo
{
    [SerializeField] private AudioSource audioSourceSfx; //AudioSource= Spoty
    
    public void ReproducirSonido(AudioClip clip) //clip= canci�n
    {
        //Reproducir una vez el sonido.
        audioSourceSfx.PlayOneShot(clip);
    }

}
