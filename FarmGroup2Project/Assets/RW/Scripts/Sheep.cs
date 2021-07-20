using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    [SerializeField] private float startSpeed;
    private float moveSpeed;


    [SerializeField] private Vector3 moveDirection;

    [SerializeField] private float force;
    private Rigidbody rb;
    private BoxCollider bc;
    [SerializeField] private GameObject heartParticlePrefab; //получить префаб
    [SerializeField] private Vector3 sheepOffset;

    [SerializeField] private float jumpForce;
    //создать шаблон енума идти, стоять
    //созд экз и присвоить знач



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }
    private void Start()
    {
        moveSpeed = startSpeed;
    }


    void Update()
    {
        //проверить состояние и идти только если сост идти
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }


    public void SaveSheep()
    {
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * force);
        ///////////////////////// тут делать
        moveSpeed = 0;      //1. Отключить скорость овце на 0 или как в тракторе!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! сделать состояние стоп
        bc.enabled = false; //2. отключить бокс коллайдер овце
        rb.useGravity = false; //3. отключить гравитацию
        //4. Спаунить патикл со здвигом над овцой или за овцой
        //спауним патикл в позиции овцы +
        GameObject particle = Instantiate(heartParticlePrefab, transform.position + sheepOffset, heartParticlePrefab.transform.rotation); // senoPrefab.transform.rotation
        Destroy(particle, 2f);
        Destroy(gameObject, 0.9f);
    }


    public void JumpThrowWater()
    {
        //отключить кинематику -отключить скорость - прыжок еед форс 
        rb.isKinematic = false;
        moveSpeed = 0; //состояние стоп
        rb.AddForce(new Vector3(0f, 1f, -1f) * jumpForce);
    }

    public void LandThrowWater()
    {
        //-включить кинематику - восстановить скорость
        rb.isKinematic = true;
        moveSpeed = startSpeed; //состояние идти
    }



}
