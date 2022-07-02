using System.Collections;
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

    void OnValidate()
    {
        //1.
        if (num==0)
        {
            szam = "";
        }
       else if (num%2==0)
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
        fuz=a+","+b+"," + c;
    }
}
