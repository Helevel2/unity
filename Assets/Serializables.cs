using UnityEngine;

public class Serializables : MonoBehaviour
{
    [SerializeField]int intvar;
    [SerializeField]float floatvar;
    [SerializeField]string stringvar;
    [SerializeField] bool boolvar;
    [SerializeField] float summa;


    void Start()
    {
        Debug.Log(intvar + floatvar);
    }

    void OnValidate()
    {
        summa = intvar + floatvar;
    }
}
