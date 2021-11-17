using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AbrirLivro : MonoBehaviour
{
    GameObject livro;

    // Start is called before the first frame update
    void Start()
    {
        livro = GameObject.Find("livro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        // this object was clicked - do something
        AbreLivro();
    }

    void AbreLivro(){
        SceneManager.LoadScene(4);
    }
}
