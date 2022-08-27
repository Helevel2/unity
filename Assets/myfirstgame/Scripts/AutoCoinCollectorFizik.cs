using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoinCollectorFizik : MonoBehaviour
{
    [SerializeField] float maxSpeed = 1;
    [SerializeField] float acceleration = 1;
    Vector3 velocity;
    [SerializeField] Rigidbody rigidBody;
    void OnValidate()
    {
        if (rigidBody == null)
        {
            rigidBody = GetComponent<Rigidbody>();
        }
    }
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rigidBody.velocity);
    }

    void FixedUpdate()
    {
        Transform followable = FindsClosestCollectable();

        Vector3 selfPos = transform.position;
        Vector3 targetPos = followable.position;
        targetPos.y = selfPos.y;

        Vector3 direction = targetPos - selfPos;
        direction.Normalize();
        rigidBody.velocity = Vector3.MoveTowards(rigidBody.velocity, direction * maxSpeed, Time.fixedDeltaTime * acceleration);
    }

    Transform FindsClosestCollectable()
    {
        Collectible[] allCollectables = FindObjectsOfType<Collectible>();
        List<Transform> transformList = new List<Transform>();
        foreach (var item in allCollectables)
        {
            transformList.Add(item.transform);
        }
        return TransformHelper.FindClosest(transformList, transform);
    }
}
