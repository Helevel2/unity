using UnityEngine;

public class Calc : MonoBehaviour
{
    [Header("Input Numbers")]
    [SerializeField] float num1;
    [SerializeField] float num2;
    [Space]
    [Header("Output Numbers")]
    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float rate;


    void OnValidate()
    {
        summa = num1 + num2;
        difference = num1 - num2;
        product = num1 * num2;
        rate = num1 / num2;
    }
    
}
