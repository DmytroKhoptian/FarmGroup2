using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraktorMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool isMove;



    void Update()
    {
        if (isMove == true)
        {
            if (((transform.position.x >= -22f) && (direction == -1f)) || ((transform.position.x <= 22f) && (direction == 1f)))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
        }
    }


    public void MoveRight()
    {
        direction = 1f;
        isMove = true;
    }
    public void MoveLeft()
    {
        direction = -1f;
        isMove = true;
    }
    public void StopMove()
    {
        isMove = false;
    }


}
