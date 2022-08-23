using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightlimit : MonoBehaviour
{
    [SerializeField] float minimum;
    [SerializeField] float maximum;

    void Update()
    {
        Vector3 position = transform.position;

        if (position.y < minimum)
            position.y = minimum;
        else if (position.y > maximum)
            position.y = maximum;

        transform.position = position;
    }
}
