using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grade_calculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Declearing Var / inputing 
        string Name;
        int[] Grade = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

        //inputing name
        Name = "Yasin";

        //If statement 
        if(Name == "Yasin")
        {
            Debug.Log("Welcome Yasin");
            Debug.Log("Here is your Grade");
            Debug.Log(Grade[0]);
        }
        while (Grade[0] == Grade[0])
        {
            Debug.Log("This Grade is an A!");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
