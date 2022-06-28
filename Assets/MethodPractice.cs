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
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        power = Mathf.Pow(a, b);
    }
}
