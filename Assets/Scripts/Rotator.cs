using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float xAngle=2.0f, yAngle, zAngle;

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(xAngle, yAngle, zAngle, Space.Self); 
    }
}
