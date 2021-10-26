using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableChildren : MonoBehaviour
{
    public GameObject[] DeactivateThese;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        for(int i = 0; i < DeactivateThese.Length; i++)
        { DeactivateThese[i].SetActive(false); }
  
    }

    private void OnEnable()
    {

    }
}
