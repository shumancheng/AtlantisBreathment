using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    //Variablen
    int currentCamIndex = 0;
    WebCamTexture tex;
    public RawImage display;
    public Text counter;
    public Text countDown;
    private Slider slider;
    private int c = 0;


    public void SwapCam_Clicked()
    {
        if (WebCamTexture.devices.Length > 0)
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;
        }
    }


    public void StartStopCam_Clicked() 
    {
        //if i have a camera, i ll switch it off
        if (tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        // if i don't have camera, I cplay it
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;
            tex.Play();
        }
    }

    private void Start()
    {
      
        StartStopCam_Clicked();
        counter.text = "Anzahl: 0";
    }



    public void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            c++;
        }
        counter.text = "Count: "+ c;
    }

}
