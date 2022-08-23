using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnLerp : MonoBehaviour
{

    [SerializeField] float a;
    [SerializeField] float b;
    [SerializeField] float t;
    [SerializeField] float LertUnClamped;
    [SerializeField] float mathflerp;
    [SerializeField] float Lert;
    [SerializeField] float mathflerpN;
    void OnValidate()
    {
        LertUnClamped = LerpUnClamped(a, b, t);
        mathflerp = Mathf.LerpUnclamped(a, b, t);
        Lert = Lerp(a, b, t);
        mathflerpN = Mathf.Lerp(a, b, t);
    }

    float LerpUnClamped(float a, float b, float t)
    {
        float dif = b - a;
        return t * dif + a;
    }
    float Lerp(float a, float b, float t)
    {
        float LertUnClamped = LerpUnClamped(a, b, t);
        float min = Mathf.Min(a, b);
        float max = a > b ? a : b;
        return Mathf.Clamp(LertUnClamped, min, max);
    }


}
