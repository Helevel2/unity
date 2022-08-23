using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listpractice : MonoBehaviour
{
    [SerializeField] List<string> list;
    [SerializeField] bool hasApple;
    [SerializeField] int strawberryCount;

    void OnValidate()
    {
        //list.Add("banan");
        list.Remove("korte");
        //list.RemoveAt(0);
        //list.Clear();
        hasApple = list.Contains("alma");
        strawberryCount = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == "eper")
                strawberryCount++;
            //Debug.Log(list[i]);
        }

    }
}
