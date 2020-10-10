using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus){
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
            // print("Bagus");
        }
    }

    public void GVRon(){
        gvrStatus = true;
        print("GVR ON");
    }

    public void GVRonRed(){
        gvrStatus = true;
        print("Ini Kubus Merah");
    }

    public void GVRonBlack(){
        gvrStatus = true;
        print("Ini Kubus Hitam");
    }

    public void GVRoff(){
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
