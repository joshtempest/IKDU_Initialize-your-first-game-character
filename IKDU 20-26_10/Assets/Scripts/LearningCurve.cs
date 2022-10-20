using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 55;
    //int ageIncrement = 5;
    // Start is called before the first frame update
    void Start()
    {
        int startAge = 10;
        int ageIncrement = 5;
        int computedAge = ComputeAge(ageIncrement);
        float pi = 3.14f;

        pi = startAge; //pi <- startAge; pi := startAge

        //startAge + pi = pi; TOTAL NONSENSE!!!
        startAge = (int)pi;
        currentAge = startAge + ageIncrement;
        //Debug.Log($"My intial age was {startAge}, and my current age is {currentAge}");
    }

    // Update is called once per frame
    void Update()
    {
        //float startAge = 123.3f;
    }
    int ComputeAge(int a)
    {
        int result = currentAge+a;
        Debug.Log(result);
        return result;
    }
}
