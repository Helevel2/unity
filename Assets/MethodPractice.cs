using UnityEngine;

public class MethodPractice : MonoBehaviour
{

    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float abs;
    [SerializeField] float power;
    void OnValidate()
    {
        min = minimum2(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        power = Mathf.Pow(a, b);
    }

    float minimum(float n1, float n2)
    {
        float min;
        if (n1<n2)
        {
            min = n1;
        }
        else
        {
            min = n2;
        }
        return min;
    }

    float minimum2(float n1, float n2)
    {
        if (n1 < n2)
            return n1;
        else
            return n2;
    }

    float absolute(float n1)
    {
        if (n1<0)
        
            return -n1;
    return n1;
        
    }
}
