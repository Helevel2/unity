using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] Transform positionToFollow;
    // [SerializeField] float speed;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField, Range(0, 10)] float startStamina;
    [SerializeField] float regenerateSpeed;
    [SerializeField] float stamina;
    //    float stamina;
    bool regenerating;

    void Start()
    {
        stamina = startStamina;
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
        float distance = Vector3.Distance(positionToFollow.position, transform.position);
        float speed = speedOverDistance.Evaluate(distance);

        Vector3 startPos = transform.position;
        transform.position = Vector3.MoveTowards(
                        transform.position,
                        positionToFollow.position,
                        speed * Time.deltaTime);
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;
        Vector3 vectorToTarget = positionToFollow.position - transform.position;
        transform.rotation = Quaternion.LookRotation(vectorToTarget);

        stamina -= step;
        if (stamina <= 0)
        {
            regenerating = true;
            stamina = Mathf.Max(0, stamina);
        }
    }
}
