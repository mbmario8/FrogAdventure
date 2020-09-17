using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //getcomponent
    public GameObject menuInicial;



    
        //restart_button
    public void restartGame() {


        SceneManager.LoadScene("lvl01");

    }


   
}
