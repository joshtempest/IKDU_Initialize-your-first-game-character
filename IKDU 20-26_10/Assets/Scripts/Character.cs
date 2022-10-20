using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 1;
        Debug.Log(characterName);
        Debug.Log(characterLevel);
        LevelUp(characterLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Tells level of character after level up
    /// </summary>
    public void LevelUp(int characterLevel)
    {
        Debug.LogFormat("Your name is {0} and you are currently level: {1}, DO YOUR BEST!", characterName, characterLevel);
        Debug.Log($"{characterName} has gained enough experience, LEVEL UP");
        characterLevel += 1;
        Debug.Log($"{characterName} is now level: {characterLevel}. Well done!");
    }
}
