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

    // Start is called before the first frame update
    void Start()
    {
        Button btn = GameObject.Find("botaoDesafio").GetComponent<Button>();
        btn.onClick.AddListener(ComecarDesafio);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void ComecarDesafio(){  
        GameObject.Find("imagemArtefato").GetComponent<RectTransform>().sizeDelta = new Vector2(100, 50);
        Debug.Log("Ele começou o desafio");
        Invoke("ExecuteAfterTime", 2);
    }


    void ExecuteAfterTime(){

        SceneManager.LoadScene(1);

    }
}
