using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public bool activated;
    public GameObject[] ActivatedObjects;
    public GameObject[] OtherObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (!activated)
        { 
            for(int i = 0; i < ActivatedObjects.Length; i++)
            {
            ActivatedObjects[i].SetActive(true);
            activated = true;
            }
            for(int i = 0; i < OtherObjects.Length; i++)
            {
                if (OtherObjects[i].activeSelf)
                {
                    OtherObjects[i].transform.parent.GetComponent<ActivateObject>().activated = false;
                    OtherObjects[i].SetActive(false);
                }   
            }
        }
        
        else
        {
            for (int i = 0; i < ActivatedObjects.Length; i++)
            {
                ActivatedObjects[i].SetActive(false);
                activated = false;
            }
        }
    }

 
}
