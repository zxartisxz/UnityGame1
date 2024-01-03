//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimeLeft;
    //public Text gameProgressReference;
    public Text gameProgress;
    public static int winCondition;


    public static float timeRemaining, addTimeFloat = 3.0f, addTimePlaceHold;
    int seconds, minutes;
    bool pausePressed = false;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 31f;
        addTimePlaceHold = 0;
        /*
        gameProgress.text = "Game progress:\n" +
               ButtonHandler.scoreToAdd + "/" + winCondition + "(" +
                ButtonHandler.scoreToAdd / winCondition + "%)";
        */
        ButtonHandler.scoreToAdd = 1;
    }

    // Update is called once per frame
    void Update()
    {
        int percentCompleted = (int)((float)(ButtonHandler.scoreToAdd -1)/ 
            (float)winCondition *100);
        //Debug.Log("percentCompleted :" + percentCompleted);
        //float percentCompleted = ((float)ButtonHandler.scoreToAdd - 1) /
        //(float)winCondition * 100;
        int number = (ButtonHandler.scoreToAdd-1);
        //****************Game Progression*****************************
        gameProgress.text = "Game progress:\n" +
                number + "/" + winCondition + "(" +
                 percentCompleted + "%)";
        if (timeRemaining > 0 && !pausePressed)
        {
            
            timeRemaining -= Time.deltaTime;
            seconds = (int)timeRemaining % 60;
            minutes = (int)timeRemaining / 60;
            TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) +
                "\n<color=lime>+" + addTimePlaceHold + " seconds!</color>";
        }


        if (ButtonHandler.addTime)
        {
            //b = System.Math.Round(a, 2);
            //<color=green> Correct! </color>
            //timeRemaining += addTimeFloat //System.Math.Round(addTimeFloat,1);
            timeRemaining += (float)System.Math.Round(addTimeFloat,1);
            ButtonHandler.addTime = false;
            addTimePlaceHold = (float)System.Math.Round(addTimeFloat, 1);
            /*TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) +
               "\n+ <color=green>" + addTimeFloat +"</color>";*/
        }
        else if (pausePressed)
        {
            TimeLeft.text = "Time: " + string.Format("{0,1:00}:{1,2:00}", minutes, seconds) + " Paused!";
        }

        //***************LOSE CONDITION********************************
        else if(timeRemaining < 0) //Game Over
        {
            SceneManager.LoadScene("LoseScene");
        }
        //***************WIN CONDITION********************************
        if(percentCompleted >= 100)
        {
            SceneManager.LoadScene("VictoryScene");
        }

    }

    public void PressPause()
    {
        pausePressed = !pausePressed;
        //Debug.Log("Pause button pressed!");
    }
}
