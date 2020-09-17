using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{

    //botaão restart nivel

    public void Restart(string lvlname) 
    {
        SceneManager.LoadScene(lvlname);

    }
}
