using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveWorld : MonoBehaviour
{
    public float rotationSpeed = 50;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * rotationSpeed);
        }

    }

    public void MoveWorld(int direction)
    {
        this.transform.Rotate(new Vector3(0, 0, direction) * Time.deltaTime * rotationSpeed);
    }


}
