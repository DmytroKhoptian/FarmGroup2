using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StudentsAge : int
{
    AlexK = 40,
    AlexR = 31,
    Veron = 14
}

public class MyEnums : MonoBehaviour
{
    //модификтор_доступа enum имя : тип
    //{
    //    имя1 = значение1,
    //    имя2 = значение2,
    //}

    StudentsAge studentsAge;



    void Start()
    {
        studentsAge = StudentsAge.AlexR; // назначить состояние

        int a =  (int)studentsAge; // получить значение состояния
        print(studentsAge);
        print(a);
        if(studentsAge == StudentsAge.Veron) // сравнить состояние
        {

        }
        
    }

    
}
