using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour
{

    //public GameObject buttonGameObject; //future feature
    public Text buttonText;
    public static bool addTime = false;

    public static int buttonNumericValue, scorePoint, scoreToAdd,
        correctStreak = 0, wrongStreak = 0, difficulityStep;
    public static bool buttonClicked = false, buttonClicked2 = false;

    private GameObject resultingText;
    public Text resultingTexts;

    public GameObject equationGameObject;
    public Text equationText;

    private void Start()
    {
        scoreToAdd = difficulityStep;
        wrongStreak = 0;
        correctStreak = 0;
        scoreToAdd  = 0;
        scorePoint = 0;

        //testing 
        resultingText = GameObject.Find("Result");
        resultingTexts = resultingText.GetComponent<Text>();
        resultingTexts.text = "";


        equationGameObject = GameObject.Find("Equation");
        equationText = equationGameObject.GetComponent<Text>();
        //Debug.Log("equationText: " + equationText);


        /* //Future development
       buttonGameObject = GameObject.Find("Text");
       //buttonText = buttonGameObject.GetComponent<Text>();
       buttonText = buttonGameObject.GetComponentInChildren<Text>();
       Debug.Log("buttonText.text: " + buttonText.text);
       */


    }

    public void SetText()
    {
        buttonNumericValue = int.Parse(buttonText.text);
        if(ProblemGenerator.result1 == buttonNumericValue)
        {
            resultingTexts.text = equationText.text + "" +
                buttonText.text + "<color=lime> Correct! </color>";

            buttonClicked = true;
            buttonClicked2 = true;
            scorePoint += scoreToAdd;
            addTime = true;
            correctStreak++;
            wrongStreak = 0;
            
        }
        else
        {
            resultingTexts.text = equationText.text + "" +
                buttonText.text + "<color=red> Wrong! </color>";

            buttonClicked = true;
            buttonClicked2 = true;

            wrongStreak++;
            correctStreak = 0;
        }
        if(correctStreak == 3)
        {
            correctStreak = 0;
            scoreToAdd += difficulityStep;
            ProblemGenerator.minRand += difficulityStep;
            ProblemGenerator.maxRand += difficulityStep;
            Timer.addTimeFloat += 0.2f;
            
            
        }
        if (wrongStreak == 3)
        {
            wrongStreak = 0;
            scoreToAdd -= difficulityStep;
            ProblemGenerator.minRand -= difficulityStep;
            ProblemGenerator.maxRand -= difficulityStep;
            Timer.addTimeFloat -= 0.2f;
        }
    }
 
}
