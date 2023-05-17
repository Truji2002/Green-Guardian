using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public GameObject controller1;
    public GameObject controller2;

    private bool isController1Active = true;

    private void Start()
    {
        controller1.SetActive(true);
        controller2.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isController1Active = !isController1Active;

            controller1.SetActive(isController1Active);
            controller2.SetActive(!isController1Active);
        }
    }
}
