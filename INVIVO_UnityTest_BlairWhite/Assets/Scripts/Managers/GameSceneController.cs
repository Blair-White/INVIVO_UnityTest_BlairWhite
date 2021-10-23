using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSceneController : MonoBehaviour
{
    //should probably be a singleton but ill keep moving.
    public GameObject MainCam, CameraPos1;
    public GameObject ElevatorUI, ElevatorButton, SelectText, LocationText, FadePanel;
    public GameObject IntroContainer, Elevator, FloorController1, FloorController2, FloorController3;
    public GameObject LeftDoor, RightDoor;
    private float delay;
    bool IntroFinished;
    bool returnToMain;
    bool closingDoors;
    enum PlayerStates {  }
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

        if (returnToMain)
        {
            delay += Time.deltaTime;
            if (delay > 4.0f)
            {
                SceneManager.LoadScene(1);
                delay = 0;
            }
        }

        if (closingDoors)
        {
            delay += Time.deltaTime;
            if (delay > 3.0f)
            {
                ElevatorUI.SetActive(true);
                closingDoors = false;
                delay = 0;
            }
        }

    }

    private void SetDoorAnimationsForward()
    {
        LeftDoor.GetComponent<Animator>().SetBool("Backwards", false);
        RightDoor.GetComponent<Animator>().SetBool("Backwards", false);
    }
    private void SetDoorAnimationsBackward()
    {
        LeftDoor.GetComponent<Animator>().SetBool("Backwards", true);
        RightDoor.GetComponent<Animator>().SetBool("Backwards", true);
    }
    public void SetToElevator()
    {
        SetDoorAnimationsBackward();
        LocationText.GetComponent<TextMeshProUGUI>().text = "Elevator";
    }
    public void SetToFloor1()
    {
        FloorController1.SetActive(true);
        FloorController2.SetActive(false);
        FloorController3.SetActive(false);
        Elevator.SetActive(true);
        SetDoorAnimationsForward();
        IntroContainer.SetActive(false);
        ElevatorUI.SetActive(false);
        LocationText.GetComponent<TextMeshProUGUI>().text = "Elemental Research";
        MainCam.GetComponent<Animator>().enabled = false;
        Vector3 pos = new Vector3(CameraPos1.transform.position.x, CameraPos1.transform.position.y, CameraPos1.transform.position.z);
        MainCam.transform.position = pos;
        ElevatorButton.SetActive(true);
    }

    public void SetToFloor2()
    {
        FloorController1.SetActive(false);
        FloorController2.SetActive(true);
        FloorController3.SetActive(false);
        IntroContainer.SetActive(false);
        Elevator.SetActive(true);
        ElevatorUI.SetActive(false);
        LocationText.GetComponent<TextMeshProUGUI>().text = "Artifact Research";
        MainCam.GetComponent<Animator>().enabled = false;
        Vector3 pos = new Vector3(CameraPos1.transform.position.x, CameraPos1.transform.position.y, CameraPos1.transform.position.z);
        MainCam.transform.position = pos;
        SetDoorAnimationsForward();
    }

    public void SetToFloor3()
    {
        FloorController1.SetActive(false);
        FloorController2.SetActive(false);
        FloorController3.SetActive(true);
        IntroContainer.SetActive(false);
        Elevator.SetActive(true);
        ElevatorUI.SetActive(false);
        LocationText.GetComponent<TextMeshProUGUI>().text = "Party Room!";
        MainCam.GetComponent<Animator>().enabled = false;
        Vector3 pos = new Vector3(CameraPos1.transform.position.x, CameraPos1.transform.position.y, CameraPos1.transform.position.z);
        MainCam.transform.position = pos;
        SetDoorAnimationsForward();
    }

    public void GoToMain()
    {
        delay = 0;
        returnToMain = true;
        FadePanel.SendMessage("ExitScene");
    }
}
