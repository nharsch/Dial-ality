using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spriteState : MonoBehaviour

private string NOSNOW = "MountainImage"
private string SNOW = "SnowMountainImage"
private string FIRE = "MountainImage"; // TODO add fire mountain image

{

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
            if (sunLevel == 3) {
                this.ChangeImage(NOSNOW);
            }
            else {
                this.ChangeImage(SNOW);
            }
        }
        else  // no water
        {
            if (sunLevel == 3) {
                // TODO
                this.ChangeImage()
            }
            else {
                this.ChangeImage(NOSNOW);
            }
        }
    }
}
