using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonHandler.buttonClicked2)
        {

            if(ProblemGenerator.result1 ==
                ButtonHandler.buttonNumericValue)
            {
                //scoreToAdd =  <color=green> Correct! </color>
                score.text = "Score: " + ButtonHandler.scorePoint +
                    "\n<color=lime> + " + ButtonHandler.scoreToAdd + "</color>";
            }
            else
            {
                score.text = "Score: " + ButtonHandler.scorePoint +
                     "\n<color=red> + 0</color>";
            }

            //score.text = "Score: " + ButtonHandler.scorePoint;
            ButtonHandler.buttonClicked2 = false;
        }
    }
}
