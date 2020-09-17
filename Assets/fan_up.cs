using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan_up : MonoBehaviour
{
    public float forceFan;





    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0f,forceFan), ForceMode2D.Impulse);
        }

    }








}
