using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] Vector3 force;

    List<Rigidbody> rigidBodies = new List<Rigidbody>();
    void FixedUpdate()
    {
        foreach (Rigidbody rb in rigidBodies)
        {
            rb.AddForce(force, ForceMode.Acceleration);
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rigidBodies.Add(rb);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rigidBodies.Remove(rb);
        }
    }

}
