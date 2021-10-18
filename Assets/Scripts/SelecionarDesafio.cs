using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;
using System;

public class SelecionarDesafio : MonoBehaviour
{
    public Button button;
    RawImage imagem;
    Texture text;
    Material material;
    //Select a Texture in the Inspector to change to
    public Texture m_Texture;

    // Start is called before the first frame update
    void Start()
    {
        m_Texture = material.GetTexture("download-removebg-preview");
        Button btn = GameObject.Find("botaoDesafio").GetComponent<Button>();
        btn.onClick.AddListener(ComecarDesafio);
        imagem = GameObject.Find("imagemArtefato").GetComponent<RawImage>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void ComecarDesafio(){  
        imagem.texture = m_Texture;

        Debug.Log("Ele começou o desafio");
        
        //yield on a new YieldInstruction that waits for 5 seconds.

        Invoke("ExecuteAfterTime", 2);
        //After we have waited 5 seconds print the time again.
    }


    void ExecuteAfterTime(){

        SceneManager.LoadScene(1);
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);
        //yield return new WaitForSeconds(5);

    }
}
