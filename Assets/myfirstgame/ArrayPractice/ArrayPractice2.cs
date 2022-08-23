using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice2 : MonoBehaviour
{
    [SerializeField,Min(0)] int length;
    [SerializeField] int[] intArray;
    [SerializeField] int[] fibonacci;
    void OnValidate()
    {
        intArray = new int[length];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i + 1;
            //Debug.Log(intArray[i]);
        }
        fibonacci = new int[length];
        if (length>=1)
            fibonacci[0] = 0;
        if(length>=2)
            fibonacci[1] = 1;
        for (int i = 2; i < length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }


    }
}
