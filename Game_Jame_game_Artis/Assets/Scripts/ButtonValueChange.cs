using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonValueChange : MonoBehaviour
{
    public Text button, button1, button2, button3, button4,
        button5, button6, button7, button8, button9;
    private int buttonNumber, givenValue, PG_result1;// result1;

    // Start is called before the first frame update
    void Start()
    {
        ValueChange();

    }

    // Update is called once per frame
    void Update()
    {
        if (ProblemGenerator.equationMade)
        {
            ValueChange();

        }

    }
    private void ButtonValueMaker(int buttonNumber, int givenValue)
    { //buttonx.text = "" + givenValue;
        switch (buttonNumber)
        {
            case 0:
                button.text = "" + givenValue;
                break;
            case 1:
                button1.text = "" + givenValue;
                break;
            case 2:
                button2.text = "" + givenValue;
                break;
            case 3:
                button3.text = "" + givenValue;
                break;
            case 4:
                button4.text = "" + givenValue;
                break;
            case 5:
                button5.text = "" + givenValue;
                break;
            case 6:
                button6.text = "" + givenValue;
                break;
            case 7:
                button7.text = "" + givenValue;
                break;
            case 8:
                button8.text = "" + givenValue;
                break;
            case 9:
                button9.text = "" + givenValue;
                break;

        }
    }

    public void ValueChange()
    {
        PG_result1 = ProblemGenerator.result1;

        for (buttonNumber = 0; buttonNumber < 10; buttonNumber++)
        {
            givenValue = Random.Range(PG_result1,
                PG_result1 * 2) + Random.Range(-5,10);
            //givenValue = Random.Range(ProblemGenerator.minRand * 2,
            //    ProblemGenerator.maxRand * 2);
            ButtonValueMaker(buttonNumber, givenValue);
        }
        buttonNumber = Random.Range(0, 9);
        givenValue = PG_result1;// = ProblemGenerator.result1;
        ButtonValueMaker(buttonNumber, givenValue);
        ProblemGenerator.equationMade = false;
    }
}
