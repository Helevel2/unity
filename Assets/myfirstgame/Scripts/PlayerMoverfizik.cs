using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverfizik : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] float rotationSpeed;
    [SerializeField] Damageable damageable;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] Animator animator;

    void OnValidate()
    {
        if (damageable==null)
        {
            damageable = GetComponent<Damageable>();
        }

        if (rigidBody == null)
        {
            rigidBody = GetComponent<Rigidbody>();
        }

        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }
    }
    void Update()
    {
        if (damageable != null && damageable.hp <= 0)
            return;
        Vector3 velocity = GetInputVector();
        Move(velocity);
    }

    Vector3 GetInputVector()
    {
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        bool left = Input.GetKey(leftKey);
        bool right = Input.GetKey(rightKey);
        float x = ToAxis(right, left);
        float z = ToAxis(up, down);


        Vector3 velocity = new Vector3(x, 0, z);
        return velocity;
    }

    void Move(Vector3 velocity)
    {
        //transform.position += velocity.normalized * speed * Time.deltaTime;
        rigidBody.velocity = velocity.normalized * speed;

        bool IsRunning = velocity != Vector3.zero;
        animator.SetBool("IsRunning", IsRunning);
        if (!IsRunning)
            return;

        if (velocity != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime);
        }
    }

    float ToAxis(bool positive, bool negative)
    {
        float value;
        if (positive)
        {
            value = 1;
        }
        else if (negative)
        {
            value = -1;
        }
        else
            value = 0;
        return value;
    }
}
