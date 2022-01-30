using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noSunCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col) 
    {
        // look for sun component
        Debug.Log("enter noSunZone");
        if (col.gameObject.GetComponent<variables>() != null)
        {
            col.gameObject.GetComponent<variables>().sunLevel = 0;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit noSunZone");
    }
        
}

