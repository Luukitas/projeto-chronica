using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class painelMenu : MonoBehaviour
{
    
    public void IniciarJogo ()
    {
        SceneManager.LoadScene(0);
    }

    public void SairJogo ()
    {
        Debug.Log("Saindo!");
        Application.Quit();
    }

}
