using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour
{
    [SerializeField] Vector3 t1;
    [SerializeField] Vector3 t2;

    void Update()
    {
        transform.position = (t1 + t2) / 2f;
    }
}
