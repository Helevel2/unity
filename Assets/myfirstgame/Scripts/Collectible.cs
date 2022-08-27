using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Collectible : MonoBehaviour
{
    public int value;
    [SerializeField] Bounds bounds;

    public void Collect()
    {

        //gameObject.SetActive(false);
        //Destroy(gameObject);

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);
        transform.position = new Vector3(x, y, z);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(bounds.center, bounds.size);    
    }
}
