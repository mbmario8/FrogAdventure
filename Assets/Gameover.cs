using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gameover : MonoBehaviour
{
    //getComponent
    public GameObject gameOver;

    public string lvlname;

    //detecta colisão com Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.layer == 9)
        {

            GameOverRestart();

        }

    }
    
    //ativa gameOverPanel
    public void GameOverRestart()
    {
        SceneManager.LoadScene(lvlname);
    }





}
