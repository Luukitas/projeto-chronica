using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class AbrirQuiz : MonoBehaviour
{
    GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.Find("Cube");
        //cubo.onClick.AddListener(AbreQuiz);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown(){
        // this object was clicked - do something
        AbreQuiz();
    }

    void AbreQuiz(){
        SceneManager.LoadScene(3);
    }
}
