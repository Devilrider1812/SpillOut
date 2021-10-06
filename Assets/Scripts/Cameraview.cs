using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cameraview : MonoBehaviour
{
    public GameObject Camera;

    public GameObject TopCamera;



    private void Start()
    {
        Camera.SetActive(false);
        TopCamera.SetActive(true);


    }
    public   void InputMode(int val)
    {
        if(val ==  0)
        {
            Camera.SetActive(false);
            TopCamera.SetActive(true);

        }
        if (val == 1)
        {
            Camera.SetActive(true);
            TopCamera.SetActive(false);

        }
    }

  
}
