using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] KeyCode shootKey = KeyCode.Space;
    [SerializeField] Transform startPos;
    [SerializeField] GameObject bullet;
    [SerializeField] float speed;
    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = startPos.position;
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            rb.velocity = startPos.forward * speed;
        }
    }
}
