using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProblemGenerator : MonoBehaviour
{
    public Text screenTextMain;
    public static int variable1, variable2, variable3, result1,
        result2, minRand, maxRand;
    public static bool equationMade = false;
    int OC_Checksum;


    // Start is called before the first frame update
    void Start()
    {
        minRand = 1;
        maxRand = 10;
        screenTextMain.text = "";
        result2 = EquationMaker();
        equationMade = true;

    }
    private void Awake()
    {
        OC_Checksum = OperationCheck.checkSum;
        /*
        if (OC_Checksum != 0)
        {
            Debug.Log("OC_CheckSum: " + OC_Checksum);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {

        if (ButtonHandler.buttonClicked)
        {
            result2 = EquationMaker();
            ButtonHandler.buttonClicked = false;
            equationMade = true;
        }
    }
    public int EquationMaker()// add *,-,/,%
    {
         
        int task = 3;
        //task = Random.Range(1, 5);
        if(OC_Checksum < 6)
        {
            task = OC_Checksum;
        }
        if (OC_Checksum == 6)
        {
            task = Random.Range(1, 5);
        }
        if (OC_Checksum == 7)
        {
            task = Random.Range(1, 6);
            //Debug.Log("task = Random.Range(1, 5):" + task);
        }

        switch (task)
        {
            case 1://addition
                addFunction();
                break;
            case 2://substraction
                minusFunction();
                break;
            case 3://multiplication
                timesFunction();
                break;
            case 4://division
                divideFunction();
                break;
            case 5://modulo
                moduloFunction();
                //Debug.Log(" moduloFunction()");
                break;
            case 6:
                moduloFunction();
                break;
        }
        return result1;
    }
    // use 2 different random generators,
    // so it dont influence each other!
    //int seed = 32;
    //  UnityEngine.Random.Initstate(seed); 
    //   UnityEngine.Random.Range(0,2);
    //*************
    //System.Random random = new System.Random(seed);
    //random.Next(0,2);
    //
    public int addFunction()
    {
        variable1 = Random.Range(minRand, maxRand);
        variable2 = Random.Range(minRand, maxRand);
        result1 = variable1 + variable2;
        screenTextMain.text = variable1 + " + " + variable2 + " = ";
        return result1;
    }
    public int minusFunction()
    {
        variable1 = Random.Range(minRand, maxRand);
        variable2 = Random.Range(minRand, maxRand);
        result1 = variable1 - variable2;
        screenTextMain.text = variable1 + " - " + variable2 + " = ";
        return result1;
    }
    public int timesFunction()
    {
        variable1 = 1 + Random.Range((int)((float)(minRand / 4)),
            (int)((float)(maxRand / 2)));
        variable2 = 1 + Random.Range((int)((float)(minRand / 4)),
            (int)((float)(maxRand / 2)));
        result1 = variable1 * variable2;
        screenTextMain.text = variable1 + " x " + variable2 + " = ";
        return result1;
    }
    public int divideFunction()
    {

        variable2 = Random.Range(1,10);
        variable1 = Random.Range(9,maxRand + Random.Range(5, 20));
        variable3 = variable1 - (variable1 % variable2);
        result1 = variable3 / variable2;
        screenTextMain.text = variable3 + " : " + variable2 + " = ";
        return result1;
    }
    public int moduloFunction()
    {
        variable1 = Random.Range((int)((float)(minRand / 2)), maxRand+10);
        variable2 = Random.Range(2, (int)((float)(minRand / 2)) + 2);
        result1 = variable1 % variable2;
        screenTextMain.text = variable1 + " % " + variable2 + " = ";
        return result1;
    }

}
