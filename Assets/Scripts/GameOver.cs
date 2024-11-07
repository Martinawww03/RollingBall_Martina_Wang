using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TerminarJuego();
        }
    }

    public void TerminarJuego()
    {
        SceneManager.LoadScene(2);

    }
}
