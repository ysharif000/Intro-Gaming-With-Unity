using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class grade_calculator : MonoBehaviour
{


    

    // Start is called before the first frame update
    void Start()
    {

        // Declearing Var.
        string Name;
        int[] Grades;

        //Inputing Name && Grades
        Name = "Yasin";
        Grades = new int[10];
        Grades[0] = 100;
        Grades[1] = 92;
        Grades[2] = 87;
        Grades[3] = 200;
        Grades[4] = -20;
        Grades[5] = 52;
        Grades[6] = 82;
        Grades[7] = 75;
        Grades[8] = 67;
        Grades[9] = 88;
        
        // Averages Grades 
        double average = (Grades[0] + Grades[1] + Grades[2] + Grades[5] + Grades[6] + Grades[7] + Grades[8] + Grades[9]) /8 ;
       
        
        
        // Outputing If statement with Debug.Log 
        if (Name == "Yasin")
        {
            Debug.Log("Welcome Yasin.");

            Debug.Log("Here are your grades:");
            
            for (int i = 0; i < Grades.Length; i++)
            {
                Debug.Log(Grades[i]);

                if (i == 0)
                {
                    Debug.Log("This Grade is an A!");
                    Debug.Log("WoW! A perfect score!");
                    
                }
                
                else if (i == 1)
                {
                    Debug.Log("This Grade is an A!");
                }

                if (i == 2)
                {
                    Debug.Log("This grade is a B.");
                }

                else if (i == 6)
                {
                    Debug.Log("This grade is a B.");
                }

                if (i == 9)
                {
                    Debug.Log("This grade is a B.");
                }

                else if (i == 7)
                {
                    Debug.Log("This grade is a C.");
                }
                
                if (i == 8)
                {
                    Debug.Log("This grade is a D.");
                }

                else if (i == 5 )
                {
                    Debug.Log("This grades is a F.");
                }

                else if (i == 3 )
                {
                    Debug.Log("This is out of range of 0-100.");
                }

                if (i == 4)
                {
                    Debug.Log("How did you even get this grade?");
                }

                
                
                    




            }
        }
                Debug.Log("Here is your final grade: " + average);
                Debug.Log("we have displayed all grades for " + Name);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
