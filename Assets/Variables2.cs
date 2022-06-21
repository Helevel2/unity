using UnityEngine;

public class Variables2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a, b, c;
        a = 5;
        b = 3;
        c = a + b;
        c = 2;
        Debug.Log(c);

        c += 5; //c=c+5
        c -= 3; //c=c-3
        c *= 2; //c=c*2
        c /= 4; //c=c/4
        c++;    //c=c+1
        ++c;    //c=c+1
        Debug.Log(c);

        int x = a + b * c;
        int y = (a + b) * c;
        Debug.Log(x);
        Debug.Log(y);
    }

    
}
