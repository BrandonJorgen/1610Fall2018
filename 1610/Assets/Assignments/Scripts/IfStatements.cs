using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public bool LightOn;
    public string Password;
    public int A, B, C;
    public FloatData WizardPower, PawnPower;
    public NameId Lock, Key;
    
    private void Update ()
    {
        if (LightOn)
        {
            print("The Light is on.");
        }
        else
        {
            print("The Light is off.");
        }

        if (Password == "OU812")
        {
            print("You are correct.");
        }

        if (C == A + B)
        {
            print(C);
        }

        if (WizardPower.Value > PawnPower.Value)
        {
            print("Wizard Wins!");
        }

        if (Lock == Key)
        {
            print("Open door.");
        }

    }
}
