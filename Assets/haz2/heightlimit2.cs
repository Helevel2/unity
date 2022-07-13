using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightlimit2 : MonoBehaviour
    
{
    [SerializeField] float min;
    [SerializeField] float max;
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, min, max);
        transform.position = pos;
    }
}
