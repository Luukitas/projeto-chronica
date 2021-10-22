using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class RecuperarTextoLivro : MonoBehaviour
{
    string texto;
    Button botaoSair;

    // Start is called before the first frame update
    void Start()
    {
        texto = "Aproximadamente em 3400 a.C, dois reinos, o Alto e Baixo Egito, se estabeleceram próximo ao Crescente Fértil. O Crescente Fértil era uma região incomum, pois possuía um solo bem fértil que era capaz de fornecer várias plantas comestíveis, assim surgindo as sociedades agrícolas. \n\n Em 3100 a.C. surgiu o primeiro faraó que uniu os dois reinos, o rei Menes, formando a capital do Antigo Egito, que posteriormente viria a ser uma grande metrópole. Os faraós eram os governantes egípcios, considerados tanto como líderes políticos quanto líderes religiosos. Como líderes políticos, os faraós travavam as guerras, faziam leis e supervisionavam seu terreno. Como líderes religiosos, eles eram considerados como intermediários entre os vários deuses e a população. \n\n Um dos faraós que reinou no Egito, entre 1333-1323 a.C., se chamava Tutancâmon. Este rei ocupou o trono ainda criança e morreu com apenas 19 anos. Conforme as tradições religiosas, Tutancâmon foi mumificado e enterrado em uma tumba com várias riquezas e obras de arte. \n\n Um dos símbolos do Antigo Egito, representado principalmente pela arte, era o cajado e o mangual, originalmente associado aos deuses egípcios. O cajado significa a realeza e o mangual a fertilidade da terra. A tumba de Tutancâmon, KV62, também ficou conhecida por possuir obras de arte com esses objetos.";
        GameObject.Find("textoLivro").GetComponent<TextMeshProUGUI>().text = texto + "";
        botaoSair = GameObject.Find("botaoSair").GetComponent<Button>();
        botaoSair.onClick.AddListener(Sair);
        DestravaMouse();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void DestravaMouse(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Sair(){
        SceneManager.LoadScene(2);
    }
}