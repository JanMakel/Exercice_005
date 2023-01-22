using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    //Variables
    public float nums1;
    public float nums2;
    public float nums3;

    //Function that gets 3 real numbers and returns de 3 parameters summed and divided by 3
    private float realValues(float num1, float num2, float num3)
    {
        return (num1 + num2 + num3) / 3;
       
    }

    private void Start()
    {
        //call of the fuction and Showing on the console the result
        realValues(nums1, nums2, nums3);
        Debug.Log($"{realValues(nums1, nums2, nums3)}");
    }

}
