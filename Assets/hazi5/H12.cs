using UnityEngine;

public class PalindromeTest : MonoBehaviour
{
    [SerializeField] string input = "Indul a görög aludni.";
    [Space]
    [SerializeField] bool isPalindrome;

    void OnValidate()
    {
        isPalindrome = IsPalindrome(input);
    }
    bool IsPalindrome(string s)
    {
        if (s == null)
            return false;

        s = s.ToLower();
        s = s.Replace(" ", "");
        s = s.Replace(",", "");
        s = s.Replace(".", "");
        s = s.Replace("!", "");
        s = s.Replace("?", "");

        char[] a = s.ToCharArray();
        for (int i = 0; i < a.Length / 2; i++)
        {
            if (a[i] != a[a.Length - 1 - i])
                return false;
        }
        return true;
    }
}
