using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomSpriteState : MonoBehaviour
{
    public Image ione;
    public Image itwo;
    public Image i2;
    public Image i3;
    private int sunLevel = 0;
    private bool watered = false;
    private float instTime = 0.0f;
    public float imageDelay = 1.0f;
    private int nextImage = 0;
    void showNextImage()
    {
        myimages[nextImage - 1].disable;
        myimages[nextImage].enabled;  // set game object image
        
        if(nextImage > myimages.Length)
        {
            nextImage = 0;
        }
        else
        {
            nextImage += 1;
        }      
    }


    void Start()
    {
        public Image[] myimages =  new Images []{ ione, itwo, ithree, ifour };
    }

    void Update()
    {
        sunLevel = this.gameObject.GetComponent<variables>().sunLevel;
        watered = this.gameObject.GetComponent<variables>().watered;
        instTime = Time.time;
        if ((imageDelay + instTime) > Time.time)
        {
            showNextImage();
            instTime = Time.time;
        }

        if (watered)
        {
            if (sunLevel == 0)
            {
                //tom cold  
            }
            if (sunLevel == 1)
            {
                // state 1 watered
            }
            if (sunLevel == 2)
            {
                //state 2 watered
            }
            if (sunLevel == 3)
            {
                //tom hot
                this.gameObject.GetComponent<variables>().watered = false;
            }
        }
        else  // no water
        {
            if (sunLevel == 0)
            {
                  //tom cold
            }
            if (sunLevel == 1)
            {
                // state 1 watered
            }
            if (sunLevel == 2)
            {
                // state 2
            }
            if (sunLevel == 3)
            {
                //tom hot
                this.gameObject.GetComponent<variables>().watered = false;
            }
        }
    }
}
