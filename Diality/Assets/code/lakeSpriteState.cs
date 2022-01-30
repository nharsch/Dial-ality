using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lakeSpriteState : MonoBehaviour
{
    private string DEF = "Lake";
    private string STEAM = "LakeSteaming";
    private string DRAINED = "LakeDrained"; 
    private string FROZEN = "LakeFrozen"; 

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

    void Update()
    {
        int sunLevel = this.gameObject.GetComponent<variables>().sunLevel;
        bool watered = this.gameObject.GetComponent<variables>().watered;
        
        if (watered) 
        {
            if (sunLevel == 0) {
                this.ChangeImage(FROZEN);
            } 
            if (sunLevel == 1) {
                this.ChangeImage(DEF);
            }
            if (sunLevel == 2) {
                this.ChangeImage(STEAM);
            }
            if (sunLevel == 3) {
                this.gameObject.GetComponent<variables>().watered = false;
            }
        }
        else  // no water
        {
            this.ChangeImage(DRAINED);
        }
    }
}
