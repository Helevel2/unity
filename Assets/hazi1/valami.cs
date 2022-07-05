using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valami : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    // Start is called before the first frame update
    void Start()
    {
        a += b;
        b = a - b;
        a = a - b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
