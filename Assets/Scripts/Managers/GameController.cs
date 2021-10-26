using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    enum GameStates { Main }


    public void MoveToCredits()
    {
        SceneManager.LoadScene(2);
    }

    public void MoveToMain()
    {
        SceneManager.LoadScene(1);
    }

    public void MoveToGameScene1()
    {
        SceneManager.LoadScene(3);
    }

    public void MoveToGameScene2()
    {

    }

    public void MoveToGameScene3()
    {

    }
}
