using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotate : MonoBehaviour
{
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotateChange);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
}
