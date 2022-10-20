using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 1;
        int EXP = 0;
        //Debug.Log(characterName);
        //Debug.Log(characterLevel);
        int newCharacterLevel = LevelUp(characterLevel, EXP);
        Debug.Log($"The new level is {newCharacterLevel}");
    }

    /// <summary>
    /// Computes level of character before and after level up
    /// </summary>
    int LevelUp(int Level, int EXP)
    {
        Debug.LogFormat("Your name is {0} and you are currently level: {1}, You have {2}. You need 100 to level up. DO YOUR BEST!", characterName, Level, EXP);
        Debug.Log($"{characterName} has gained 145 EXP");
        EXP += 145;
        Debug.Log($"{characterName} has gained enough experience, LEVEL UP");
        Level += 1;
        EXP -= 100;
        Debug.Log($"{characterName} is now level: {Level} and {EXP} EXP. Well done!");
        return Level;
    }
}
