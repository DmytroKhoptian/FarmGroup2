using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepDestroyer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Sheep sheep = other.gameObject.GetComponent<Sheep>();

        if(sheep != null)
        {
            Destroy(other.gameObject);
        }

    }
}
