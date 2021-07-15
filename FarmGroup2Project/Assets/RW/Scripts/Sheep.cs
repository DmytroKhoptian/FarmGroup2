using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirection;

    [SerializeField] private float force;
    private Rigidbody rb;
    [SerializeField] private GameObject heartParticlePrefab; //получить префаб


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();


    }


    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }


    public void SaveSheep()
    {
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * force);
        ///////////////////////// тут делать
        //1. Отключить скорость овце на 0 или как в тракторе
        //2. отключить бокс коллайдер овце
        //3. отключить гравитацию
        //4. Спаунить патикл со здвигом над овцой или за овцой
        //спауним патикл в позиции овцы
        GameObject particle = Instantiate(heartParticlePrefab, transform.position, heartParticlePrefab.transform.rotation); // senoPrefab.transform.rotation
        Destroy(particle, 2f);

        Destroy(gameObject, 0.9f);
    }

}
