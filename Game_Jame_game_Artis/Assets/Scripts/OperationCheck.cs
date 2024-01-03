using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class OperationCheck : MonoBehaviour
{
    public static int check1 = 0, check2 = 0, check3 = 0, check4 = 0, check5,
        check6, check7;

    public static int checkSum, someVariable;
    private int[] arreyOfOperations;
    private static int[] aOP;
    public static int specificOperation;

    public Toggle toggle1, toggle2, toggle3, toggle4, toggle5, toggle6, toggle7;

    void Start()
    {       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //*********************Toggle button UI*****************
        if (Input.GetMouseButtonDown(0))
        { //toggle1.isOn ? true : false;
            check1 = !toggle1.isOn ? 0 : 1;
            //Debug.Log("toggle1.isOn is: " + toggle1.isOn);
            check2 = !toggle2.isOn ? 0 : 2;
            //Debug.Log("toggle2.isOn is: " + toggle2.isOn);
            check3 = !toggle3.isOn ? 0 : 3;
            //Debug.Log("toggle3.isOn is: " + toggle3.isOn);
            check4 = !toggle4.isOn ? 0 : 4;
            //Debug.Log("toggle4.isOn is: " + toggle4.isOn);
            check5 = !toggle5.isOn ? 0 : 5;
            //Debug.Log("toggle5.isOn is: " + toggle5.isOn);
            check6 = !toggle6.isOn ? 0 : 6;
            //Debug.Log("toggle6.isOn is: " + toggle6.isOn);
            check7 = !toggle7.isOn ? 0 : 7;
            //Debug.Log("check7 is: " + check7 + "and toggle7.isOn: " + toggle7.isOn);

            checkSum = check1 + check2 + check3 + check4 + check5 + check6 + check7;
            /*
            arreyOfOperations = new int[6] {0, check1 * 1, check2 * 2,
            check3 * 3, check4 * 4, check5 * 5 };

            aOP = arreyOfOperations;

            Array.Sort(aOP);
            Array.Reverse(aOP);
           
            someVariable = UnityEngine.Random.Range(0, checkSum); //checkSum-1 

            specificOperation = aOP[someVariable];
            */
            /*
           Debug.Log("aOP0: " + aOP[0] + "; aOP1: " + aOP[1] +
                   "; aOP2: " + aOP[2] + "; aOP3: " +
                   aOP[3] + "; aOP4: " + aOP[4] + "; aOP5: " + aOP[5]);
           */
        }
    }


   
  
}
