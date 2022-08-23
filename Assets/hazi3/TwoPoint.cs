using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class TwoPoint : MonoBehaviour
{
    [SerializeField] Color colorA;
    [SerializeField] Color colorB;
    [SerializeField] Transform p1;
    [SerializeField] Transform p2;
    [SerializeField] float targetposition;
    [SerializeField] float speed;

    float pos;

    void Start()
    {

        pos = targetposition;    
    }
    void Update()
    {


        pos = Mathf.MoveTowards(pos, Mathf.Clamp01(targetposition), speed * Time.deltaTime);

        if (p1==null || p2==null)
        {
            return;
        }

        transform.position = Vector3.Lerp(p1.position, p2.position, pos);
    }

    void OnDrawGizmos()
    {
        float r = 0.25f;
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(p1.position, r);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(p2.position, r);
        Gizmos.color = Color.Lerp(colorA, colorB, pos);
        Gizmos.DrawLine(p1.position, p2.position);
    }
}
