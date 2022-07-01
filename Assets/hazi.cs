using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazi : MonoBehaviour
{

    [SerializeField] int num;
    [SerializeField] string szam;
    [SerializeField] int exponent;
    [SerializeField] int eredmény;

    void OnValidate()
    {
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


    }
}
