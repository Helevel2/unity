using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuggveny : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float c;
    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float clampp;
    [SerializeField] float clampp01;
    [SerializeField] float abs;
    [SerializeField] float sign;
    [SerializeField] float floor;
    [SerializeField] float ceil;
    [SerializeField] float round;


    void OnValidate()
    {
        max = maximum(a, b);
        min = minimum(a, b);
        clampp = clap(a, b, c);
        clampp01 = clap01(a, b, c);
        abs = absolute(c);
        sign = Sign(c);
        floor = Floor(c);
        ceil = Ceil(c);
        round = Round(c);
    }

    float maximum(float n1, float n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
            return n2;
    }

    float minimum(float n1, float n2)
    {
        if (n1 < n2)
        {
            return n1;
        }
        else
            return n2;
    }

    float clap(float n1,float n2, float n3)
    {
        if (n3 > n1 && n3 < n2 && n1<n2)
        {
            return n3;
        }
        if (n3 < n1 && n3 > n2 && n1>n2)
        {
            return n3;
        }
        else if (n3 < n1 && n3 < 2 && n1 < n2)
        {
            return n1;
        }
        else if (n3 < n1 && n3 < 2 && n1 > n2)
        {
            return n2;
        }
        else if (n3 > n1 && n3 > 2 && n1 < n2)
        {
            return n2;
        }
        else if (n3 > n1 && n3 > 2 && n1 > n2)
        {
            return n1;
        }
        else
            return n1;
        
    }

    float clap01(float n1, float n2, float n3)
    {
        n1 = 0;
        n2 = 1;
        if (n3 < n1)
        {
            return n1;
        }
        else if (n3 > n2)
        {
            return n2;
        }
        else return n3;
    
    }
    float absolute(float n1)
    {
        if (n1 < 0)

            return -n1;
        return n1;

    }
    float Sign(float n1)
    {
        if (n1 < 0)
        {
            return -1;
        }
        return 1;
    }

    float Floor(float n1)
    {
        return n1 - (n1 % 1f);
    }

    float Ceil(float n1)
    {
        float a = n1 % 1f;
        if (a == 0)
            return n1;
        return n1 + 1 - a;
    }

    float Round(float n1)
    {
        float a = n1 % 1f;
        if (a <= 0.5)
            return Floor(n1);
        return Ceil(n1);
    }
}
