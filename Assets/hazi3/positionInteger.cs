using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionInteger : MonoBehaviour
{

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = Mathf.Round(pos.z);
        transform.position = pos;
    }
}
