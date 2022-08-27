using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]

public class followFizik : MonoBehaviour
{
    [SerializeField] List<Transform> followables;
    // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField, Range(0, 10)] float startStamina;
    [SerializeField] float regenerateSpeed;
    [SerializeField] float stamina;
    [SerializeField] Rigidbody rigidBody;
    //    float stamina;
    bool regenerating;

    void Start()
    {
        stamina = startStamina;
    }

    void OnValidate()
    {
        if (rigidBody == null)
        {
            rigidBody = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {

        if (regenerating)
            Regen();
        else
            Move();
    }

    private void Regen()
    {
        stamina += Time.deltaTime * regenerateSpeed;
        if (stamina >= startStamina)
        {
            regenerating = false;
            stamina = startStamina;
        }
    }

    private void Move()
    {
        if (followables == null || followables.Count == 0)
            return;
        Transform followable = TransformHelper.FindClosest(followables, transform);
        if (followable == null)
            return;
        float distance = Vector3.Distance(followable.position, transform.position);
        float speed = speedOverDistance.Evaluate(distance);
        Vector3 velocity = followable.position - transform.position;
        velocity.Normalize();
        velocity *= speed;

        rigidBody.velocity = velocity;

        Vector3 startPos = transform.position;
        /*transform.position = Vector3.MoveTowards(
                        transform.position,
                        followable.position,
                        speed * Time.deltaTime);*/
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;
        Vector3 vectorToTarget = followable.position - transform.position;
        transform.rotation = Quaternion.LookRotation(vectorToTarget);

        stamina -= step;
        if (stamina <= 0)
        {
            regenerating = true;
            stamina = Mathf.Max(0, stamina);
        }
    }
}
