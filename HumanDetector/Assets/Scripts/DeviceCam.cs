using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceCam : MonoBehaviour
{
    static WebCamTexture deviceCamera; 
    // Start is called before the first frame update
    void Start()
    {
        if(deviceCamera == null)
        {
            deviceCamera = new WebCamTexture();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RawImage>().texture = deviceCamera; 
        deviceCamera.Play();
    }
}

