/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazi : MonoBehaviour
{

    [SerializeField] int num;
    [SerializeField] string szam;
    [SerializeField] int exponent;
    [SerializeField] int eredmeny;
    [SerializeField] string a;
    [SerializeField] string b;
    [SerializeField] string c;
    [SerializeField] string fuz;
    [SerializeField] string text;

    void OnValidate()
    {
        //1.
        if (num == 0)
        {
            szam = "";
        }
        else if (num % 2 == 0)
        {
            szam = "Páros";
        }
        else
        {
            szam = "Páratlan";
        }
        //2.
        eredmeny = (int)Mathf.Pow(num, exponent);

        //3.
        fuz = a + "," + b + "," + c;
        //4.
        text = "";
        for (int i = 1; i <= num; i++)
        {
            if (i < num)
            {
                text = text + i + ", ";
            }
            else
                text = text + i;

        }


    }

    void Start()
    {
        

        for (int i = 1; i < num; i++)
        {
            Debug.Log(i);
        }
        if (num % 3 == 0 && num % 5 == 0)
        {
            Debug.Log("fizzbuzz");
        }
        else if (num % 5 == 0)
        {
            Debug.Log("buzz");
        }
        else if (num % 3 == 0)
            Debug.Log("fizz");
        else
        {
            Debug.Log(num);
        }
    }
}*/
