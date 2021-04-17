using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{

    [SerializeField] private GameManager manager;
    private int CountUp = 1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            manager.CountUp(CountUp);
        }
            
    }
}