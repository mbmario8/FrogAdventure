using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Camera : MonoBehaviour
{
    public Transform player;
    private void FixedUpdate()
    {

        transform.position = Vector2.Lerp(transform.position, player.position, 01f);

    }
}
