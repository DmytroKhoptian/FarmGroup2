using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateAxis;
    private Transform wheelTrans;

    void Start()
    {
        wheelTrans = transform.GetChild(0).GetChild(0);
    }

     
    void Update()
    {
        //transform.Rotate(Vector3.up * 10 * Time.deltaTime); // так не надо (-:
        wheelTrans.transform.Rotate(rotateAxis * rotateSpeed * Time.deltaTime);
    }
}
