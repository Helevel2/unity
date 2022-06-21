using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myFirstVariable;
        myFirstVariable = 5;
        Debug.Log(myFirstVariable);
        myFirstVariable = 7;
        Debug.Log(myFirstVariable);
        //int a, b, c;
        int secondVariable = 3;
        Debug.Log(secondVariable);
        int x = 3, y = 7, z = 2;
        y = 22;
        int summa = x + y + z;
        Debug.Log(summa);

        int product = x * y * z;
        Debug.Log(product);

        int dif = x - y;
        Debug.Log(dif);
        int rate = x / y;
        Debug.Log(rate);
        int negated = -x;
        Debug.Log(negated);
        int modulo = x%y;
        Debug.Log(modulo);

    }
}
