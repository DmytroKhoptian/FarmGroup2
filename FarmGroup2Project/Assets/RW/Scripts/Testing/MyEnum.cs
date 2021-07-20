using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { Man = 1, Woman = -1, Gender = 0 }

public enum Days : int
{
  Mondey =  1,


}



public class MyEnum : MonoBehaviour
{
    State state = State.Man;


    enum Presidents { Pytin = 65, Obama = 61, Tramp = 49} // обьявление перечисления(создание)

    Presidents myPresident = Presidents.Tramp; // Создание экземпляра перечисления и присвоили значение
    Presidents russionPresident = Presidents.Pytin; //// Создание еще одного экземпляра перечисления

    private void Awake()
    {
        if(myPresident == Presidents.Pytin) //сравнение по состоянию(имени)
        {
            print("Тикай");
        }

        if((int)myPresident >= 60)  // сравниваем значение
        {
            print("Опытный лидер");
        }
        else
        {
            print("НЕ Опытный лидер");
        }



















        print(state);
        state = State.Gender;

        int i = (int)state;
        print(i);
    }

    private void Start()
    {
        print(state);
        if (state == State.Man)
        {
            print("муж");
        }
        else if (state == State.Woman)
        {
            print("жен");
        }
        else if (state == State.Gender)
        {
            print("ген");
        }


    }
}
