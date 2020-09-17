using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_platform : MonoBehaviour
{
    //getComponents
    TargetJoint2D target;
    BoxCollider2D box;
    //variaveis
    public float time;

    private void Awake()
    {
        //getComponents
        target = GetComponent<TargetJoint2D>();
        box = GetComponent<BoxCollider2D>();

    }

    private void Update()
    {



    }

    private void falling()
    {

        target.enabled = false;
        box.isTrigger = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {

            Invoke("falling", time);
            Destroy(gameObject, 3f);

        }
    }

}
