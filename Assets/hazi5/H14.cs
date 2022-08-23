using System.Collections.Generic;
using UnityEngine;

public class UniqCharactersCounter : MonoBehaviour
{
    [SerializeField]
    string text =
        "Megszentségteleníthetetlenségeskedéseitekért";
    [Space]
    [SerializeField] int uniqCharacterCount;

    void OnValidate()
    {
        uniqCharacterCount = CountUniqCharacters(text);
    }
    int CountUniqCharacters(string s)
    {
        text = text.ToLower();
        List<char> characters = new List<char>();
        foreach (char c in s)
        {
            if (!characters.Contains(c))
                characters.Add(c);
        }

        return characters.Count;
    }
}
