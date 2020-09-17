using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxdown : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.layer == 9)
        {
            rb.simulated = true;
            rb.AddForce(Vector2.down * force, ForceMode2D.Impulse);
        }

    }


}
