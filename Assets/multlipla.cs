using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multlipla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        for (int a = 1; a <= 10; a++)
        {
            for (int b = 1; b <= 10; b++)
            {
                int c = a * b;
                Debug.Log(a + " * " + b + " = " + c);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
