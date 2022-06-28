using UnityEngine;

public class SwitchValue : MonoBehaviour
{
    [SerializeField] float num1;
    [SerializeField] float num2;

    void Start()
    {
        //megcserelni seged valtozo nélkül
        
        float tar = num1;
        num1 = num2;
        num2 = tar;
    }
}
