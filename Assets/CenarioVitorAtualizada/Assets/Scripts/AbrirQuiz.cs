using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class AbrirQuiz : MonoBehaviour
{
    GameObject tv;

    // Start is called before the first frame update
    void Start()
    {
        tv = GameObject.Find("Cube");
        Debug.Log(tv);
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
