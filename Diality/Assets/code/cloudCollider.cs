using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cloudCollider : MonoBehaviour
{

    string LAKE = "Lake";
    string MOUNTAIN = "Mountains1";
    public GameObject objUnderCloud;

    void precip(GameObject obj)
    {
        if (obj.GetComponent<variables>() != null)
        {
            if (this.GetComponent<cloudVariables>().raining) 
            {
                obj.GetComponent<variables>().watered = true;
            }
        }
        // TODO: snow?
        if (obj.name == LAKE)
        {
            // rain fills up lake, stops clouds
            if (this.GetComponent<cloudVariables>().raining)
            {
                this.GetComponent<cloudVariables>().intensity = 0;
                this.GetComponent<cloudVariables>().raining = false;
            }
        }
    }

    void evap(GameObject obj) 
    {
        // evaporate lake
        if (obj.name == LAKE)
        {
            if (obj.GetComponent<variables>().sunLevel == 2)
            // sun over lake starts creating cloud
            {
                if (this.GetComponent<cloudVariables>().intensity < 2)
                {
                    this.GetComponent<cloudVariables>().intensity = 1;
                }
            }
            // sun over lake creates cloud dries lake bed
            else if (obj.GetComponent<variables>().sunLevel == 3)
            {
                this.GetComponent<cloudVariables>().intensity = 2;
                obj.GetComponent<variables>().watered = false;
            }
        }
    }

    void condensate(GameObject obj)
    {
        // mountain object starts storm
        if (obj.name == MOUNTAIN) 
        {
            if (this.GetComponent<cloudVariables>().intensity > 1)
            {
                // start raining
                this.GetComponent<cloudVariables>().raining = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        // Debug.Log("cloud enter: " + col.gameObject.name);
        this.objUnderCloud = col.gameObject;
    }

    void OnTriggerStay2D(Collider2D col) 
    {
        // Debug.Log("cloud stay: " + col.gameObject.name);
        this.objUnderCloud = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        // if lake leaving, remove clouds
        this.objUnderCloud = null;
        if (col.gameObject.name == LAKE)
        {
            if (this.GetComponent<cloudVariables>().intensity < 2)
            {
                this.GetComponent<cloudVariables>().intensity = 0;
            }
        }
    }

    void Update() {
        if (this.objUnderCloud)
        {
            precip(this.objUnderCloud);
            evap(this.objUnderCloud);
            condensate(this.objUnderCloud);
        }
    }

}
