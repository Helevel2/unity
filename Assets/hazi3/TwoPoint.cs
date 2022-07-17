using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPoint : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float F;
    void Update()
    {
        Vector3 half = (p1.position + p2.position) / 2;
        if (F <= 0)
        {
            transform.position = p1.position;
        }
        else if (F >= 1)
        {
            transform.position = p2.position;
        }
        else if (F == 0.5)
        {
            
            transform.position = half;
        }
        /*else if(F==0.4)
        {
            transform.position = p1.position + (p2.position / 2);
        }*/
    }
}
