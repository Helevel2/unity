using UnityEngine;

public class DividerCount : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int countOfDeviders;

    void OnValidate()
    {
        countOfDeviders = 0;
        /*int i = 1;
        while (i<num)
        {
            bool isDevidable = num % i == 0;
            if (isDevidable)
            {
                countOfDeviders++;
               
            }
            i++;
        }*/
        for (int i = 1; i < num; i++)
        {
            bool isDevidable = num % i == 0;
            if (isDevidable)
            {
                countOfDeviders++;
            }
        }



    }
}
