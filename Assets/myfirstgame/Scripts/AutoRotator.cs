using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    [SerializeField] float angularspeed;
    void Update()
    {
        transform.Rotate(Vector3.up, angularspeed * Time.deltaTime, Space.World);
    }
}
