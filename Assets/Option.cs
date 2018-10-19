using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    // Use this for initialization
    public bool isCorrect;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject core;
    public Gonext Next;

    void Start () {

    }
    // Update is called once per frame

    void Update () {
        if (Next.Nextone == true)
        {
            option1.GetComponent<TextMesh>().color = Color.white;
            option2.GetComponent<TextMesh>().color = Color.white;
            option3.GetComponent<TextMesh>().color = Color.white;
        }
    }

    private void OnMouseDown()
    {        
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red; 
            GameController.realAnswerOption.GetComponent<TextMesh>().color = new Color(1, 0.64f, 0.19f);
            //realAnswer.GetComponent<TextMesh>().color = new Color(255, 172, 124, 255);
        }
        isCorrect = false;
    }
}
