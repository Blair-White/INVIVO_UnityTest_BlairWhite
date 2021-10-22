using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoController : MonoBehaviour
{
    public float ExitSeconds;
    private float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        if(delay > ExitSeconds) { SceneManager.LoadScene(1); }
    }


}
