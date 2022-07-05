using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primes : MonoBehaviour

    
{
    void Start()
    {
        int count = 0;
        int number = 2;
        while(count<100)
        {
            bool isprime = true;
            if (number < 2)
            {
                isprime = false;
            }
            isprime = true;
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                {
                    isprime = false;
                }
            }
            if (isprime)
            {
                Debug.Log(number);
                count++;
            }
        }
    }

}
