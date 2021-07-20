using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpThrowWather : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();

        if (sheep != null)
        {
            sheep.JumpThrowWater();
        }
    }
}
