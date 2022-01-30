using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class sunCollider : MonoBehaviour
{
    int SUN_LEVEL = 2;
    void changeSunLevel(GameObject obj, int level)
    {
        if (obj.GetComponent<variables>() != null)
        {
            if (obj.GetComponent<variables>().sunLevel != level) {
                obj.GetComponent<variables>().sunLevel = level;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        Debug.Log("sun collission");
        {
            changeSunLevel(col.gameObject, SUN_LEVEL);
        }
    }

    void OnTriggerStay2D(Collider2D col) 
    {
        Debug.Log("sun stay");
        {
            changeSunLevel(col.gameObject, SUN_LEVEL);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit sun collission");
    }
        
}
