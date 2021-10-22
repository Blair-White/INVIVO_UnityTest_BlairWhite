using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public GameObject MainCam, CameraPos1, CameraPos2, CameraPos3;
    public GameObject ElevatorUI, SelectText;
    public GameObject IntroContainer, FloorController1, FloorController2, FloorController3;
    private float delay;
    bool IntroFinished;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!IntroFinished)
        {
            delay += Time.deltaTime;
            if(delay > 14.0f)
            {
                IntroFinished = true; delay = 0;
                ElevatorUI.SetActive(true);
            }
        }
    }

    public void SetToFloor1()
    {
        FloorController1.SetActive(true);
        IntroContainer.SetActive(false);
        ElevatorUI.SetActive(false);
        MainCam.GetComponent<Animator>().enabled = false;
        Vector3 pos = new Vector3(CameraPos1.transform.position.x, CameraPos1.transform.position.y, CameraPos1.transform.position.z);
        Debug.Log(pos);
        MainCam.transform.position = pos;

    }

    public void SetToFloor2()
    {

    }

    public void SetToFloor3()
    {

    }
}
