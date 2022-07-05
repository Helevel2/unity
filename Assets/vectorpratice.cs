using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorpratice : MonoBehaviour
{
    [SerializeField] Vector2 myfirst2D;
    [SerializeField] Vector3 myfirst3D;
    [SerializeField] Vector3 mysecond3D;
    [SerializeField] float multiplier;
    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 diference;
    [SerializeField] Vector3 product;
    [SerializeField] float lenght;
    [SerializeField] Vector2 normalize;

    void OnValidate()
    {
        summa = myfirst3D + mysecond3D;

        diference = myfirst3D - mysecond3D;

        product = myfirst3D * multiplier;

        lenght = myfirst2D.magnitude;

        normalize = myfirst2D.normalized;

        float x = myfirst3D.x;
        float y = myfirst3D.y;
        float z = myfirst3D.z;

        Vector3 vector3LocalVariable = new Vector3(1, 2, 3);
        Vector2 vectorLocalVariable = new Vector2(1, 2);
    }
}
