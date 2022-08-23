using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cricle : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float radius;
    [SerializeField] float angularSpeed;

    float angle;
    void Update()
    {
        angle += angularSpeed * Time.deltaTime;
        float angleInRad =angle * Mathf.Deg2Rad;
        Vector3 pos = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle));
        pos *= radius;
        pos += center;
        transform.position = pos;
    }
}
