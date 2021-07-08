using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;
    
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }


}
