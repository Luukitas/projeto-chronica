using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenQuiz : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("UmCube");
        //cube.onClick.addEventListener(BuscarPergunta);
    }

    // Update is called once per frame
    void Update()
    { 

    }

    void BuscarPergunta(){
        Debug.Log("Houve um click");
    }
}
