using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevShutoff : MonoBehaviour
{
    public GameObject[] Deactivate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shutoff()
    {
        for (int i = 0; i < Deactivate.Length; i++)
        {
            Deactivate[i].SetActive(false);
        }
    }
}
