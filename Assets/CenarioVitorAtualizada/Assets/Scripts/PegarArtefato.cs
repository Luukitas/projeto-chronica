using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PegarArtefato : MonoBehaviour
{
    GameObject sarcofago;
    public Text texto;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        sarcofago = GameObject.Find("Coffins");
        texto.text = "Parabéns!" + "\n" + "Você recuperou o Sarcófago de Tutancâmon";
        texto.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision colisao)
    {
        texto.enabled = true;
        Debug.Log("Artefato Recuperado!!");
        Invoke("VoltaCena", 2);
    }

    void VoltaCena(){
        SceneManager.LoadScene(2);
    }
}
