using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class RecuperarPerguntas : MonoBehaviour
{
    string pergunta, respostaCorreta;
    string[] respostas;
    Button botaoA, botaoB, botaoC, botaoD;

    // Start is called before the first frame update
    void Start()
    {
        botaoA = GameObject.Find("botaoRespostaA").GetComponent<Button>();
        botaoB = GameObject.Find("botaoRespostaB").GetComponent<Button>();
        botaoC = GameObject.Find("botaoRespostaC").GetComponent<Button>();
        botaoD = GameObject.Find("botaoRespostaD").GetComponent<Button>();
        respostas = new string[4] {"resposta a", "resposta b", "resposta c", "resposta d"};
        pergunta = "Uma Pergunta";
        respostaCorreta = respostas[1];
        DestravaMouse();
        RecuperaDados(pergunta, respostas);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void DestravaMouse(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void RecuperaDados(string pergunta, string[] respostas){
        GameObject.Find("textoPergunta").GetComponent<Text>().text = pergunta + "";
        GameObject.Find("textoRespostaA").GetComponent<Text>().text = respostas[0] + "";
        GameObject.Find("textoRespostaB").GetComponent<Text>().text = respostas[1] + "";
        GameObject.Find("textoRespostaC").GetComponent<Text>().text = respostas[2] + "";
        GameObject.Find("textoRespostaD").GetComponent<Text>().text = respostas[3] + "";
        botaoA.onClick.AddListener(ClickA);
        botaoB.onClick.AddListener(ClickB);
        botaoC.onClick.AddListener(ClickC);
        botaoD.onClick.AddListener(ClickD);
    }

    void OnMouseDrag()
    {
        Debug.Log("Clicou");
        //rend.material.color -= Color.white * Time.deltaTime;
    }

    void ClickA(){
        VerificarRespostaCorreta(respostas[0], respostaCorreta);
    }

    void ClickB(){
        VerificarRespostaCorreta(respostas[1], respostaCorreta);
    }

    void ClickC(){
        VerificarRespostaCorreta(respostas[2], respostaCorreta);
    }

    void ClickD(){
        VerificarRespostaCorreta(respostas[3], respostaCorreta);
    }

    void VerificarRespostaCorreta(string resposta, string respostaCorreta){
        if(resposta == respostaCorreta){
            Debug.Log("Resposta Correta");
            SceneManager.LoadScene(2);
        }else{
            Debug.Log("Resposta Errada");
        }
    }
}