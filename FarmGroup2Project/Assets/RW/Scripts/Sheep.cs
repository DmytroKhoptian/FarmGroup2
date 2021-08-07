using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    // [SerializeField] private SheepProperty sheepProperty;
    [SerializeField] private List<SheepProperty> sheepProperty;

    //[SerializeField] private float startSpeed;   
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float force;  
    [SerializeField] private GameObject heartParticlePrefab; //получить префаб
    [SerializeField] private Vector3 sheepOffset;
    [SerializeField] private float jumpForce;

    private Rigidbody rb;
    private BoxCollider bc;
    private MeshRenderer mr;
    private float moveSpeed;
    int randomSheepPropertyIndex;

    [SerializeField] private SoundManager soundManager;

    [SerializeField] private GameEvent SheepDroppedEvent;
    [SerializeField] private GameEvent SheepSavedEvent;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
        mr = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        randomSheepPropertyIndex = Random.Range(0, sheepProperty.Count);

        //Debug.Log(sheepProperty[randomSheepPropertyIndex].Name); // get
        //sheepProperty[randomSheepPropertyIndex].Name = "Molly"; // set
        //Debug.Log(sheepProperty[randomSheepPropertyIndex].Name); // get

        moveSpeed = sheepProperty[randomSheepPropertyIndex].Speed;
        mr.material = sheepProperty[randomSheepPropertyIndex].Material;
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

        //Destroy(gameObject, 0.9f);
        gameObject.SetActive(false); //дз Добавить коорутину или таймер

        soundManager.PlaySheepHitClip();
        SheepSavedEvent.Raise();
    }
    public void DestroySheep()
    {
        soundManager.PlayDropClip();
        SheepDroppedEvent.Raise();
       // Destroy(gameObject);
        gameObject.SetActive(false);
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
        moveSpeed = sheepProperty[randomSheepPropertyIndex].Speed; //состояние идти
    }



}
