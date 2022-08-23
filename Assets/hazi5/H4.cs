using System;
using UnityEngine;

public class MinMaxFinder : MonoBehaviour
{
    [SerializeField] float[] values = Array.Empty<float>();
    [Space]
    [SerializeField] float minimum;
    [SerializeField] float maximum;

    void OnValidate()
    {
        minimum = Min(values);
        maximum = Max(values);
    }
    float Min(float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    float Max(float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}
