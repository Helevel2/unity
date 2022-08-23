using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] myFirstArray;
    [SerializeField] int min;
    [SerializeField] int sum;
    [SerializeField] int product;
    [SerializeField] float avg;
    void OnValidate()
    {
        if (myFirstArray.Length == 0)
        {
            min = 0;
        }
        else
        {
            min = myFirstArray[0];
            for (int i = 1; i < myFirstArray.Length; i++)
            {
                int current = myFirstArray[i];
                if (current < min)
                {
                    min = current;
                }
            }
        }

        sum = 0;
        for (int i = 0; i < myFirstArray.Length; i++)
        {
            sum += myFirstArray[i];
        }
        product = myFirstArray[0];
        for (int i = 1; i < myFirstArray.Length; i++)
        {
            product *= myFirstArray[i];
        }
        avg = (float) sum/myFirstArray.Length;
        
        
    }

}
