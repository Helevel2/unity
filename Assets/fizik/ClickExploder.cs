using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickExploder : MonoBehaviour
{
    [SerializeField] float explosionForce = 10;
    [SerializeField] float explosionRadius = 10;
    [SerializeField] float upwardMod = 0.5f;
    [SerializeField] LayerMask layermask;
    [SerializeField] float maxDistance;

    [SerializeField] ParticleSystem particles;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 screenPoint = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenPoint);

            //Ray r2 = new Ray(transform.position, transform.forward);
            bool isHit = Physics.Raycast(ray, out RaycastHit hit,maxDistance, layermask);
            if (isHit)
            {
                foreach(Rigidbody rb in FindObjectsOfType<Rigidbody>())
                {
                    rb.AddExplosionForce(explosionForce, hit.point, explosionRadius,upwardMod);
                }
                particles.transform.position = hit.point;
                particles.Play();
                //Debug.Log($"Yeey! {hit.collider.name}");
            }
        }
    }
}
