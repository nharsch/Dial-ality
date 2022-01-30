using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cloudSpriteState : MonoBehaviour
{
    private string DISSAPATING = "raincloudDissappating";
    private string NONE = "";
    private string CLOUD = "rainCloud";

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

    void SetRainVis(bool enabled) {
        GameObject rain = GameObject.Find("rain");
        Image[] images = rain.GetComponentsInChildren<Image>();
        foreach (Image img in images) {
            img.enabled = enabled;
        }
    }


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bool raining = this.gameObject.GetComponent<cloudVariables>().raining;
        int intensity = this.gameObject.GetComponent<cloudVariables>().intensity;

        // change
        if (intensity == 0) {
            // Debug.Log("no cloud");
            this.ChangeImage(NONE);
        }
        else if (intensity == 1) {
            // Debug.Log("cloud diss");
            this.ChangeImage(DISSAPATING);
        }
        else if (intensity == 2) {
            // Debug.Log("cloud full");
            this.ChangeImage(CLOUD);
        }

        if (intensity > 0 && raining) {
            // Debug.Log("raining");
            this.SetRainVis(true);
        } else {
            // Debug.Log("not raining");
            this.SetRainVis(false);
        }
    }
}
