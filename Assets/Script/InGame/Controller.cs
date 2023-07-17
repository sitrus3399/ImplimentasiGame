using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Character karakter;
    public Transform maxX;
    public Transform minX;
    bool isLeft;
    bool isRight;
    void Start()
    {
        karakter = GetComponent<Character>();
    }

    void Update()
    {
        if(isLeft)
        {
            transform.position += new Vector3(-karakter.speed * Time.deltaTime, 0, 0);
            if (transform.position.x <= minX.position.x)
            {
                transform.position = new Vector3(minX.position.x, transform.position.y, transform.position.z);
            }
        }

        if(isRight)
        {
            transform.position += new Vector3(karakter.speed * Time.deltaTime, 0, 0);
            if (transform.position.x >= maxX.position.x)
            {
                transform.position = new Vector3(maxX.position.x, transform.position.y, transform.position.z);
            }
        }
    }

    public void MoveLeft()
    {
        isLeft = true;
    }
    public void relaseMoveLeft()
    {
        isLeft = false;
    }

    public void MoveRight()
    {
        isRight = true;
    }
    public void relaseMoveRight()
    {
        isRight = false;
    }
}
