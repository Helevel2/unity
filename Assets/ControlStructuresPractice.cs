using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{

    [SerializeField] int a = 3;
    [SerializeField] int b = 5;
    [SerializeField] int n = 0;
    void Start()
    {
        //Selection
        if (a > b)
        {
            Debug.Log("A is Greater than B");
        }
        else
        {
            Debug.Log("A is not Greater than B");
        }

        //Loop /ciklus
        int i = 1;
        while (i<=10)
        {
            Debug.Log(i);
            i++;
        }

        /*int g = 1;
        int h = 1;
        while (g<=5)
        {
            if (h % 3 == 0)
            {
                Debug.Log(h);
                g++;
            }
            h++;
        }*/

        int h = 1;
        while (i <= n)
        {
            Debug.Log(h*3);
            i++;
        }

        for (int j = 0; j < n; j++)
        {
            Debug.Log(i * 3);
        }
    }
}
