using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterFadePanel : MonoBehaviour
{

    private bool finished;
    private bool exitingScene;
    private Image myImage;

    [SerializeField]
    private float fadeRate;

    private void Awake()
    {
        myImage = this.GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!finished)
        {
            if(!exitingScene)
            {
                myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, myImage.color.a - fadeRate);
                if(myImage.color.a <= 0)
                {
                    finished = true;
                }
            }

            if (exitingScene)
            {
                myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, myImage.color.a + fadeRate);
                if (myImage.color.a >= 1)
                {
                    finished = true;
                }
            }

        }
    }

    public void ExitScene()
    {
        finished = false;
        exitingScene = true;
    }
}
