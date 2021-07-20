using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracktorMovement1 : MonoBehaviour
{
    enum TractorCondition { Move, Stop }

    TractorCondition tractorCondition = TractorCondition.Stop;

    [Header("Fire Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireRate;
    private float nextFire; 

    [Header("Traktor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float bounds;
    private float direction;


    private void Start()
    {
        nextFire = fireRate;
    }
    void Update()
    {
        if (tractorCondition == TractorCondition.Move)
        {
            if (((transform.position.x > -bounds) && (direction == 1f)) || ((transform.position.x < bounds) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }

        nextFire += Time.deltaTime;
    }
    public void PressLeft()
    {
        direction = -1f;
        tractorCondition = TractorCondition.Move;
    }
    public void PressRight()
    {
        direction = 1f;
        tractorCondition = TractorCondition.Move;
    }
    public void StopPress()
    {
        tractorCondition = TractorCondition.Stop;
    }

    public void PressFire()
    {
        if(nextFire > fireRate)
        {
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); // senoPrefab.transform.rotation
            Destroy(seno, 15f);

            nextFire = 0;
        }
    }
}

