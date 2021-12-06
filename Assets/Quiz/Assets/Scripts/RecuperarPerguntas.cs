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
    int codigo = 0;
    Button botaoA, botaoB, botaoC, botaoD;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("botaoRespostaA").GetComponent<Button>().onClick.AddListener(ClickA);
        GameObject.Find("botaoRespostaB").GetComponent<Button>().onClick.AddListener(ClickB);
        GameObject.Find("botaoRespostaC").GetComponent<Button>().onClick.AddListener(ClickC);
        GameObject.Find("botaoRespostaD").GetComponent<Button>().onClick.AddListener(ClickD);
        DestravaMouse();
        RecuperaDados(codigo);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void DestravaMouse(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void RecuperaDados(int codigo){
        if(codigo == 0){
            respostas = new string[4] {"Eles eram o comerciante principal do rei.", "Eles eram escribas que trocavam mensagens com outras civilizações.", "Eles eram os líderes religiosos e políticos que representavam o Antigo Egito.", "Eles eram líderes políticos e não tinham nenhuma relação com religião."};
            pergunta = "Por que os faraós eram figuras importantes no Antigo Egito?";
            respostaCorreta = respostas[2];
        }else if(codigo == 1){
            respostas = new string[4] {"A religião não era relevante politicamente.", "Como o rei era o intermediário entre o divino e a população, o governo seguia a vontade divina.", "Os deuses forneciam a maioria das riquezas que os egípcios conseguiam.", "A população votava no deus que governaria o Antigo Egito."};
            pergunta = "Como a religião era relevante politicamente?";
            respostaCorreta = respostas[1];
        }else if(codigo == 2){
            respostas = new string[4] {"Fertilidade do solo na região do Crescente Fértil.", "Desaparecimento de animais na região.", "Preferências alimentares.", "Pelos nutrientes que as comidas obtidas pelo cultivo forneciam."};
            pergunta = "Qual fator contribuiu para ocorrer a transição de práticas de caça para o cultivo de grãos?";
            respostaCorreta = respostas[0];
        }else if(codigo == 3){
            respostas = new string[4] { "Aliança temporária entre nômades.", "Unificação dos reinos Alto e Baixo Egito.", "Construção da primeira pirâmide egípcia.", "As dez pragas do Egito."};
            pergunta = "Por conta de qual fenômeno ocorreu o surgimento do primeiro faraó?";
            respostaCorreta = respostas[1];
        }else if(codigo == 4){
            respostas = new string[4] { "Empacotamento.", "Purificação.", "Ossificação.", "Mumificação."};
            pergunta = "Uma das principais crenças egípcias era a vida após a morte. Com isso dito, qual prática era comum realizar na morte do faraó?";
            respostaCorreta = respostas[3];
        }
        GameObject.Find("textoPergunta").GetComponent<Text>().text = pergunta + "";
        GameObject.Find("textoRespostaA").GetComponent<Text>().text = respostas[0] + "";
        GameObject.Find("textoRespostaB").GetComponent<Text>().text = respostas[1] + "";
        GameObject.Find("textoRespostaC").GetComponent<Text>().text = respostas[2] + "";
        GameObject.Find("textoRespostaD").GetComponent<Text>().text = respostas[3] + "";
        
    }

    void ClickA(){
        Debug.Log("a");
        VerificarRespostaCorreta(respostas[0], respostaCorreta);
    }

    void ClickB(){
        Debug.Log("b");
        VerificarRespostaCorreta(respostas[1], respostaCorreta);
    }

    void ClickC(){
        Debug.Log("c");
        VerificarRespostaCorreta(respostas[2], respostaCorreta);
    }

    void ClickD(){
        Debug.Log("d");
        VerificarRespostaCorreta(respostas[3], respostaCorreta);
    }

    void VerificarRespostaCorreta(string resposta, string respostaCorreta){
        bool passou = false;
        if(resposta == respostaCorreta){
            passou = true;
        }
        Debug.Log(passou);
        if(passou == false){
            abrirImagemErrou();
            fecharImagemAcertou();
        }if(passou == true){
            if(codigo != 4){
                codigo++;
                abrirImagemAcertou();
                fecharImagemErrou();
                RecuperaDados(codigo);
            }else{
                abrirImagemAcertou();
                fecharImagemErrou();
                Invoke("ExecuteAfterTime2", 1f);
            }
        }
    }

    void ExecuteAfterTime2() {
            SceneManager.LoadScene(5);
    }

    void abrirImagemAcertou(){
        GameObject.Find("ImageAcertou").GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
        Invoke("fecharImagemAcertou", 2f);
    }

    void fecharImagemAcertou(){
        GameObject.Find("ImageAcertou").GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
    }

    void abrirImagemErrou(){
        GameObject.Find("ImageErrou").GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
        Invoke("fecharImagemErrou", 2f);
    }

    void fecharImagemErrou(){
        GameObject.Find("ImageErrou").GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);
    }
}
