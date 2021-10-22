using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CreditsController : MonoBehaviour
{
    enum CreditState { Begin, AnimatingText, AnimatingEnd, Ended}
    CreditState State;
    public GameObject DevTitle, SpecialTitle, DevBody, SpecialBody1, SpecialBody2, ExitButton;
    private float delay;
    // Start is called before the first frame update
    void Start()
    {
        State = CreditState.Begin;
    }

    // Update is called once per frame
    void Update()
    {
        switch (State)
        {
            case CreditState.Begin:

                State = CreditState.AnimatingText;
                
                break;
            case CreditState.AnimatingText:
                delay += Time.deltaTime;
                if (delay >= 1f) DevBody.SetActive(true);
                if (delay >= 2f) SpecialBody1.SetActive(true);
                if (delay >= 3f) SpecialBody2.SetActive(true);
                if(delay > 3.5f) { delay = 0; State = CreditState.AnimatingEnd; }
                break;
            case CreditState.AnimatingEnd:
                delay += Time.deltaTime;
                if(delay >= 2.0f) { delay = 0; State = CreditState.Ended; }
                break;
            case CreditState.Ended:
                if (ExitButton.activeSelf == false) ExitButton.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(1);
    }
}
