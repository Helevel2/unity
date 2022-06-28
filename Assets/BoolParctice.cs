using UnityEngine;

public class BoolParctice : MonoBehaviour
{
    [SerializeField] bool hasRange;

    [SerializeField] int ageOfJohn;
    [SerializeField] int ageOfGreg;
    [SerializeField] bool isJohnOlderThanGreg;
    [SerializeField] bool isGregOlderThanJohn;
    [SerializeField] bool isJohnAndGregTheSameAge;
    [SerializeField] bool isJohnAndGregNotTheSameAge;
    void OnValidate()
    {
        isJohnOlderThanGreg = ageOfJohn > ageOfGreg;
        isGregOlderThanJohn = ageOfJohn < ageOfGreg;
        isJohnAndGregTheSameAge = ageOfJohn == ageOfGreg;
        isJohnAndGregNotTheSameAge = ageOfJohn != ageOfGreg;
        float f1 = 3, f2 = 5;
        bool b1 = f1 >= f2;
        bool b2 = f1 <= f2;


        bool a = true;
        bool b = false;
        bool c = false;
        int i1 = 3;
        int i2 = 6;
        int i3 = 10;
        string st = "AAA";

        bool aNegated = !a;
        bool aOrb = a || b;
        bool aAndb = a && b;

        bool x = a || b && c; //false
        bool y = (i1 > i2) || b; //false
        bool z = (i2 <= i3) && st == "BBB"; //false

    }
}
