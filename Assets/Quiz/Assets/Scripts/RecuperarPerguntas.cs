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
        respostas = new string[4] {"Eles eram o comerciante principal do rei.", "Eles eram escribas que trocavam mensagens com outras civilizações.", "Eles eram os líderes religiosos e políticos que representavam o Antigo Egito.", "Eles eram líderes políticos e não tinham nenhuma relação com religião."};
        pergunta = "Por que os faraós eram figuras importantes no Antigo Egito?";
        respostaCorreta = respostas[2];
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
            Invoke("ExecuteAfterTime2", 1.5f);
        }else{
            Debug.Log("Resposta Errada");
        }
    }

    void ExecuteAfterTime2() {
            SceneManager.LoadScene(2);
    }
}