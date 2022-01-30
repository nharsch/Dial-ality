using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cropSpriteState : MonoBehaviour
{
    private string DEF = "sprouts";
    private string GROWN = "crops";
    private string DRY = "cropsDry"; 
    private string WILT = "cropsWilting"; 

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
        this.ChangeImage(DEF);
    }

    void Update()
    {
        int sunLevel = this.gameObject.GetComponent<variables>().sunLevel;
        bool watered = this.gameObject.GetComponent<variables>().watered;
        bool grown = this.gameObject.GetComponent<cropVariables>().grown;

        if (grown) {
            this.ChangeImage(GROWN);
        } 
        else if (watered)
        {
            if (sunLevel == 0) {
                this.ChangeImage(DEF);
            } 
            if (sunLevel == 1) {
                this.ChangeImage(DEF);
            }
            if (sunLevel == 2) {
                this.ChangeImage(DEF);
            }
            if (sunLevel == 3) {
                this.gameObject.GetComponent<cropVariables>().grown = true;
            }
        }
        else  // no water
        {
            if (sunLevel == 0) {
                this.ChangeImage(DEF);
            } 
            if (sunLevel == 1) {
                this.ChangeImage(DEF);
            }
            if (sunLevel == 2) {
                this.ChangeImage(WILT);
            }
            if (sunLevel == 3) {
                this.ChangeImage(DRY);
            }
        }
    }
}
