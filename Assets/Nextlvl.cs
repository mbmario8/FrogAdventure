using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nextlvl : MonoBehaviour
{
    public string lvlname;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene(lvlname);
        }
    }





}
