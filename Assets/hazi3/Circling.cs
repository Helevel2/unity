using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Circling : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] float degreesPerSecond;

    Vector3 v;
    void Start()
    {
        v = transform.position - center.position;
    }
    void Update()
    {
        v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.down) * v;
        transform.position = center.position + v;
    }
}
