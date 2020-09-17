using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    //variaveiis
    public float speed;
    public float moveTime;


    //boll, verifica a direção
    private bool isRight;
    //vai receber o deltaTime
    private float timer;

    private void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed *  Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            isRight = !isRight;
            timer = 0f;
        }

    }

    

}
