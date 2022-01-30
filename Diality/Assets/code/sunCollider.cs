using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col) 
    {
        // look for sun component
        Debug.Log("sun collission");
        if (col.gameObject.GetComponent<variables>() != null)
        {
            col.gameObject.GetComponent<variables>().sunLevel = 2;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit sun collission");
    }
        
}
