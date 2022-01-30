using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class sunCollider : MonoBehaviour
{
    static float TIME = 2;
    public float timeRemaining = TIME;
    public GameObject objInSun;

    void changeSunLevel(GameObject obj, int level)
    {
        if (obj.GetComponent<variables>() != null)
        {
            obj.GetComponent<variables>().sunLevel = level;
        }
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        // Debug.Log("sun collission");
        this.objInSun = col.gameObject;
        if (this.objInSun.GetComponent<variables>().sunLevel < 2)
        {
            changeSunLevel(this.objInSun, 2);
        }
        // set timer
        this.timeRemaining = TIME;
    }

    void OnTriggerStay2D(Collider2D col) 
    {
        // Debug.Log("sun stay");
        this.objInSun = col.gameObject;
        if (this.objInSun.GetComponent<variables>().sunLevel < 2)
        {
            changeSunLevel(this.objInSun, 2);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        this.objInSun = null;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            this.timeRemaining -= Time.deltaTime;
        } else {
            if (this.objInSun != null) {
                this.objInSun.GetComponent<variables>().sunLevel = 3;
                this.objInSun.GetComponent<variables>().watered = false;
            }
        }
    }

}
