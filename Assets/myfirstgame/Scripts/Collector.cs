using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text uiText;
    int collectedValue;

    void Start()
    {
        UpdateText();
    }
    void OnTriggerEnter(Collider other)
    {
        Collectible collectible = other.GetComponent<Collectible>();
        

        if (collectible != null)
        {
            collectedValue += collectible.value;
            //Debug.Log($"Collected: {collectible.value}, All: {collectedValue}");

            collectible.Collect();
            UpdateText();
        }
        
    }

    void UpdateText()
    {
        if (uiText != null)
        {
            uiText.text = $"Coins: {collectedValue}";
        }
    }
}
