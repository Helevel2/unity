using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimesWithMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        int number = 2;
        while (count < 100)
        {
            bool isprime = IsPrime(number);
            if (isprime)
            {
                Debug.Log(number);
                count++;
            }
        }
    }
    bool IsPrime(float number)
    {
        bool isprime = true;
        if (number < 2)
            isprime = false;
        else
        {
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                    isprime = false;
            }
        }
        return isprime;

    }
    
}
