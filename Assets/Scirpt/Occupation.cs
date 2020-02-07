using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Occupation : MonoBehaviour {

    int occupationId;
    string occupationName;

    Occupation(int id)
    {
        switch (id)
        {
            case 0: occupationName = "骑士"; break;
            case 1: occupationName = "战士"; break;
            case 2: occupationName = "牧师"; break;
            case 3: occupationName = "法师"; break;
            case 4: occupationName = "射手"; break;
        }
    }
    Occupation(string name)
    {
        switch (name)
        {
            case "骑士": occupationId = 0; break;
            case "战士": occupationId = 1; break;
            case "牧师": occupationId = 2; break;
            case "法师": occupationId = 3; break;
            case "射手": occupationId = 4; break;
        }
    }
}
