using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmo : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(p1.position, p2.position);

    }
}
