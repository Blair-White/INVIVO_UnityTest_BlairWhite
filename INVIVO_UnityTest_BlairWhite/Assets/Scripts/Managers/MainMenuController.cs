using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    private float delay;
    private bool toCredits;
    private bool toGame;
    private bool moving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moving == true)
        {
            delay += Time.deltaTime;
            if(delay > 2.0f)
            {
                if(toCredits)
                {
                    GameController.instance.SendMessage("MoveToCredits");
                }
                if(toGame)
                {
                    GameController.instance.SendMessage("MoveToGameScene1");
                }
            }
        }
    }



    public void GotoCredits() { toGame = false; toCredits = true; delay = 0; moving = true; }
    public void GotoGame() { toGame = true; toCredits = false; delay = 0; moving = true; }
}
