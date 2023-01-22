using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Array that gets integers
    public int[] array;

    private void Start()
    {
        //Messages on the console that display the first, the third and the fifth element on the array.
        Debug.Log($"Fist element = {array[0]}");
        Debug.Log($"Third element = {array[2]}");
        Debug.Log($"Fifth element = {array[4]}");
    }
}
