using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Array that gets integers
    public int[] array;

    private void Start()
    {
        //Condition that if the array have 5 or more elements, display the messages like in Ex_04
        if (array.Length >= 5)
        {
            Debug.Log($"Fist element = {array[0]}");
            Debug.Log($"Third element = {array[2]}");
            Debug.Log($"Fifth element = {array[4]}");
        }
        else
        {
            Debug.Log($"Missing Elements");
        }
       
    }
    
}
