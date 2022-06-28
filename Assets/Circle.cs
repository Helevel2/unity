using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float area;
    [SerializeField] float kerulet;

    private void OnValidate()
    {
        area = radius * radius * Mathf.PI;
        kerulet = 2 * radius * Mathf.PI;
        
    }
}
