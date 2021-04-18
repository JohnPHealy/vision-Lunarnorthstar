using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ColourController : MonoBehaviour
{
    [SerializeField] private GameObject RedCam;
    [SerializeField] private GameObject BlueCam;
    [SerializeField] private GameObject YellowCam;
    [SerializeField] private GameObject RedMap;
    [SerializeField] private GameObject BlueMap;
    [SerializeField] private GameObject YellowMap;
    [SerializeField] private int RedLimit = 5;
    [SerializeField] private int BlueLimit = 5;
    [SerializeField] private int YellowLimit = 5;

    [SerializeField] private GameManager manager;

    private bool Redclicked = false;
    private bool Blueclicked = false;
    private bool Yellowclicked = false;

    void Start()
    {
        /*
        RedMap.SetActive(false);
        BlueMap.SetActive(false);
        YellowMap.SetActive(false);    

        RedCam.SetActive(false);
        BlueCam.SetActive(false);
        YellowCam.SetActive(false);
        */
    }

    private void Update()
    {
        manager.CountUpRed(RedLimit);
        manager.CountUpBlue(BlueLimit);
        manager.CountUpYellow(YellowLimit);
    } 

    public void Red(InputAction.CallbackContext context)
{
    if (RedLimit > 0)
    {
            if(Redclicked == false)
            {
                RedLimit -= 1;
                Redclicked = true;
                Blueclicked = false;
                Yellowclicked = false;
            }
        
            

        RedCam.SetActive(true);
            BlueCam.SetActive(false);
            YellowCam.SetActive(false);


        RedMap.SetActive(true);
            BlueMap.SetActive(false);
            YellowMap.SetActive(false);

    }
}


public void Blue(InputAction.CallbackContext context)
{
    if (BlueLimit > 0)
    {
            if (Blueclicked == false)
            {
                BlueLimit -= 1;
                Redclicked = false;
                Blueclicked = true;
                Yellowclicked = false;
            }

            RedCam.SetActive(false);
        BlueCam.SetActive(true);
            YellowCam.SetActive(false);


            RedMap.SetActive(false);
        BlueMap.SetActive(true);
            YellowMap.SetActive(false);


    }
}


public void Yellow(InputAction.CallbackContext context)
{
    if (YellowLimit > 0)
    {
            if (Yellowclicked == false)
            {
                YellowLimit -= 1;
                Redclicked = false;
                Blueclicked = false;
                Yellowclicked = true;
            }

            RedCam.SetActive(false);
            BlueCam.SetActive(false);
        YellowCam.SetActive(true);


            RedMap.SetActive(false);
            BlueMap.SetActive(false);
        YellowMap.SetActive(true);


    }
}
        

}