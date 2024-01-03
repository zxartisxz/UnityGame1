using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    public Text endGameScore;
    private bool showResult = true;
    // Start is called before the first frame update
    void Start()
    {
        //endGameScore.text = "Your Score:" + ButtonHandler.scorePoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (showResult)
        {
            //Debug.Log("ButtonHandler.scorePoint :" + ButtonHandler.scorePoint);
            endGameScore.text = "Your Score:" + ButtonHandler.scorePoint;
            showResult = false;
            //Debug.Log("Score has been shown");
        }
        
    }
}
