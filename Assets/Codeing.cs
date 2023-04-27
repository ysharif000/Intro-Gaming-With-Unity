using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codeing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // New lesson 03-08-2023

        // Arrays

        // Arrays of ints

        //initalize only name 
        // int[] numbers;

        // initalize name and size
        // int[] numbers2 = new int[5];
        // numbers2[0] = 1;
        // numbers2[1] = 2;
        // numbers2[2] = 3;
        // numbers2[3] = 4;
        // numbers2[4] = 5;


        // initalize and declare 
        // int[] numbers3 = new int[] { 1, 2, 3, 4 };

        // short cut for arrays 
        // int[] numbers4 = {5, 10 , 17, 18 };

        //for loop to print out values in my array
        // for(int i = 1; i < numbers3.Length; i++)
        // {
        //    Debug.Log("The value of numbers3 [" + i + "] is : " + numbers3[i]);
        // }

        //Strings 
        //Same holds true but we can use the string data type

        // string[] names;

        // names = new string[3];

        // names[0] = "Nick";
        // names[1] = "Sam";
        // names[2] = "Alex";

        // for (int i = 0; i <names.Length; i++)
        // {
        // Debug.Log("The value of names [" + i + " is : " + names[i]);
        // }

        // in class practices 

        // inputing Mynumbers 06 

        int[] NumbersList = { 1, 2, 3, 4, 5, 6 };

        NumbersList[0] = 1;
        NumbersList[1] = 2;
        NumbersList[2] = 3;
        NumbersList[3] = 4;
        NumbersList[4] = 5;
        NumbersList[5] = 6;


        // inputing mynumbers
        int[] Mynumbers = new int[6]; 

        Mynumbers[0] = 100;
        Mynumbers[1] = 200;
        Mynumbers[2] = 500;
        Mynumbers[3] = 600;
        Mynumbers[4] = 1200;
        Mynumbers[5] = 1;
        // inputing names 
        string[] Mynames;
        Mynames = new string[8];
        Mynames[0] = "Ben";
        Mynames[1] = "Ten";
        Mynames[2] = "Nick";
        Mynames[3] = "Mr.G";
        Mynames[4] = "Mr.S";
        Mynames[5] = "Mr.T";
        Mynames[6] = "Mr.Q";
        Mynames[7] = "L";
        // outpuing the vaules 
        for (int i = 0; i < Mynames.Length; i++)
        {
            Debug.Log("The values of names  [" + i + " is : " + Mynames[i]); 
        }
        for (int i = 0; i < Mynumbers.Length; i++)
        {
            Debug.Log("The values of numbers [" + i + " is : " + Mynumbers[i]);
        }
        for (int i = 3; i < NumbersList.Length; i++)
        {
            Debug.Log("The valuses of NumbersList [" + i + " is : " + NumbersList[i]);
        }

       // Update is called once per frame
        void Update()
        {
        
        }
    }
}


