using System;
using UnityEngine;

public class OrderChanger : MonoBehaviour
{
    [SerializeField] int[] values = Array.Empty<int>();

    void Start()
    {
        ChangeOrder(values);
    }

    void ChangeOrder(int[] array)
    {
        if (array == null)
            return;
        for (int i = 0; i < array.Length / 2; i++)
        {
            int i2 = array.Length - 1 - i;
            int temp = array[i];
            array[i] = array[i2];
            array[i2] = temp;
        }
    }
}
