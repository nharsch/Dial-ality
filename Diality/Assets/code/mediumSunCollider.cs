using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediumSunCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col) 
    {
        // look for sun component
        Debug.Log("mediumSun collission");
        if (col.gameObject.GetComponent<variables>() != null)
        {
            col.gameObject.GetComponent<variables>().sunLevel = 1;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit mediumSun collission");
    }
        
}

