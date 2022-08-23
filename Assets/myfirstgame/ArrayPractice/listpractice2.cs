using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class listpractice2 : MonoBehaviour
{
    [SerializeField] List<Transform> transforms;
    [SerializeField] Transform closest;

    void Update()
    {
        closest = FindClosest(transforms);
    }

    Transform FindClosest(List<Transform> transforms)
    {
        if (transforms == null || transforms.Count == 0)
            return null;
        Vector3 selfPos = transform.position;
        float closestDistance = Vector3.Distance(selfPos, transforms[0].position);
        Transform closest = transforms[0];
        foreach (var item in transforms)
        {
            float distance = Vector3.Distance(selfPos, item.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = item;
            }
            else if(distance==closestDistance)
            {
                int rand = Random.Range(0, 2);
                if (rand == 0)
                    closest = item;
            }
        }
        return closest;
    }
    void OnDrawGizmos()
    {
        if(closest!=null)
        Gizmos.DrawLine(closest.position, transform.position);
    }
}
