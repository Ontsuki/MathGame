using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GenerateQuestion();
    }
	// Update is called once per frame

	void Update () {
        if (Next.Nextone == true)
        {            
            GenerateQuestion();
            Next.Nextone = false;
        }
    }
    public string randomOperator;
    public int answer;
    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public static GameObject realAnswerOption;
    public Gonext Next;

    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int operatorNumber = Random.Range(0, 3);
        if(operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
            question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
        }
        else if(operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
            question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
        }
        else
        {
            randomOperator = "*";
            answer = a * b;
            question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
        }
        int option = Random.Range(0, 3);
        if(option == 0)
        {
            realAnswerOption = option1;
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-4, 0)).ToString();
			option3.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
        }
        else if(option == 1)
        {
            realAnswerOption = option2;
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(-4, 0)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<Option>().isCorrect = false;
        }
        else
        {
            realAnswerOption = option3;
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-4, 0)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = true;
        }

    }
}
