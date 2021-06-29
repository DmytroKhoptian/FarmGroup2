using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotate Property")]
    [SerializeField] Vector3 rotateDirection;
    [Range(-100f, 100f)][SerializeField] float rotateSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateDirection * rotateSpeed * Time.deltaTime);   
    }
}
