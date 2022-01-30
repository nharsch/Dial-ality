using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spriteState : MonoBehaviour
{
    private string NOSNOW = "MountainImage";
    private string SNOW = "SnowMountainImage";
    private string MELTING = "RiverMountain"; // TODO add melting mountain image
    private string FIRE = "BurntMountain"; // TODO add fire mountain image

    void ChangeImage(string imgName) 
    {
        Image[] images = this.gameObject.GetComponentsInChildren<Image>();
        foreach (Image img in images) {
            if (img.name == imgName) 
            {
                img.enabled = true;
            }
            else 
            {
                img.enabled = false;
            }
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int sunLevel = this.gameObject.GetComponent<variables>().sunLevel;
        bool watered = this.gameObject.GetComponent<variables>().watered;
        
        if (watered) 
        {
            
            if (sunLevel == 2) {
                this.ChangeImage(MELTING);
                Debug.Log("Melting");
            }
            else if (sunLevel == 3) {
                this.ChangeImage(NOSNOW); // melt
                // change water level, melt
                Debug.Log("NoSnow");
            }
            else {
                this.ChangeImage(SNOW);
                Debug.Log("snow 0");
            }
        }
        else  // no water
        {
            if (sunLevel == 3) {
                this.ChangeImage(FIRE);
            }
            else {
                this.ChangeImage(NOSNOW);
            }
        }
    }
}
