using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDifficulity : MonoBehaviour
{

    //************** Game Difficulity *******************
    public void EasyDifficulity()
    {
        ButtonHandler.difficulityStep = 1;
        Timer.winCondition = 20;//10
    }
    public void NormalDifficulity()
    {
        ButtonHandler.difficulityStep = 2;
        Timer.winCondition = 60;
    }
    public void HardDifficulity()
    {
        ButtonHandler.difficulityStep = 3;
        Timer.winCondition = 150;
    }
    public void HardPlus_Inf_Difficulity()
    {
        ButtonHandler.difficulityStep = 5;
        Timer.winCondition = 9999;
    }
}
