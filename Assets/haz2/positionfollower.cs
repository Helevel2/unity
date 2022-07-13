using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Vector3 positionToFollow;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = (positionToFollow - transform.position).normalized;
        transform.position += speed * Time.deltaTime * velocity;
    }
}
