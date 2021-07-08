using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracktorMovement : MonoBehaviour
{
    [Header("Fire Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireRate;
    private float nextFire;
    [SerializeField] Transform senoContainer;

    [Header("Traktor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float bounds;
    private float direction;
    private bool isPress;


    void Update()
    {
        if (isPress)
        {
            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }

        
    }
    public void PressLeft()
    {
        direction = -1f;
        isPress = true;
    }
    public void PressRight()
    {
        direction = 1f;
        isPress = true;
    }
    public void StopPress()
    {
        isPress = false;
    }

    public void PressFire()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); // senoPrefab.transform.rotation
            Destroy(seno, 15f);
            seno.transform.SetParent(senoContainer);
        }
    }
}

