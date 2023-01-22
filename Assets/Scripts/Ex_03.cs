using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Varibale
    public int number;

    //Fucntion to add 1 to a variable
    private void addOneToCounter()
    {
        number++;
    }

    private void Update()
    {
        //Call of the function every time you press the key A
        if (Input.GetKeyDown(KeyCode.A))
        {
            addOneToCounter();
        }
        //Condition that chekcs if the number it's more than 10 if it is, the console display a GAME OVER message
        if(number > 10)
        {
            Debug.Log("GAME OVER");
        }
    }
}
