using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Types : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 3;
        float f = 3.5f;
        string s = "Text";
        bool b1 = true;
        bool b2 = false;

        Debug.Log(i);
        Debug.Log(f);
        Debug.Log(s);
        Debug.Log(b1);
        Debug.Log(b2);

        var p = i * f;
        int v2 = (int)p;
        int p1 = (int)i * (int)f;   //9
        int p2 = (int)(i * f);      //10

        var v3 = 5;      //casting
        var v4 = v3;    //implicit casting

        var sss = s + i;    //Text3

        var sss2 = s + i + f;
        var sss3 = i + f + s;
        var sss4 = i + s + f;
    }

}
