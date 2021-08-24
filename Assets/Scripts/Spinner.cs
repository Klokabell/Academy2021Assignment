using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
// Provides a rotation speed value for the user to fiddle with and rotates the object on the z axis by that amount


  [SerializeField] float z;

    
    void Update()
    {
        transform.Rotate(0, 0, z);
    }

}
