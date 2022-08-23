using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField] Vector3 axis;
    [SerializeField] float angularspeed;
    [SerializeField] bool positiveDirection;

    float angle;

    // Update is called once per frame
    void Update()
    {
        //angle += angularspeed * Time.deltaTime;
        //transform.rotation = Quaternion.AngleAxis(angle, axis);
        float dir = positiveDirection ? 1 : -1;
        transform.Rotate(axis, dir * angularspeed * Time.deltaTime);
    }
}
