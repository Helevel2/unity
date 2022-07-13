using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PthMover : MonoBehaviour
{
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = (p2.position - p1.position).normalized;
        transform.position += speed * Time.deltaTime * velocity;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(p1.position, 0.25f);   
        Gizmos.DrawWireSphere(p2.position, 0.25f);   
        Gizmos.DrawLine(p1.position, p2.position); 
    }

}
