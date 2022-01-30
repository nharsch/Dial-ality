using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class noSunCollider : MonoBehaviour
{
    int SUN_LEVEL = 0;

    void changeSunLevel(GameObject obj, int level)
    {
        if (obj.GetComponent<variables>() != null)
        {
            if (obj.GetComponent<variables>().sunLevel != level) {
                obj.GetComponent<variables>().sunLevel = level;
            }
        }
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col) 
    {
        // Debug.Log("enter noSunZone");
        changeSunLevel(col.gameObject, SUN_LEVEL);
    }
    void OnTriggerStay2D(Collider2D col) 
    {
        // Debug.Log("stay noSunZone");
        changeSunLevel(col.gameObject, SUN_LEVEL);
    }
    void OnTriggerExit2D(Collider2D col)
    {
        // Debug.Log("exit noSunZone");
    }
        
}

