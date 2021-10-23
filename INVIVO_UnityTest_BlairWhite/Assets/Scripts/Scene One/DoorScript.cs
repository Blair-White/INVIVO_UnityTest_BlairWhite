using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorsClosed()
    {
        if(this.GetComponent<Animator>().GetBool("Backwards"))
        UI.SetActive(true);
    }
}
