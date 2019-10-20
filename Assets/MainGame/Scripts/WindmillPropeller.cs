using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillPropeller : MonoBehaviour
{
    public float speed;
    public Vector3 rotationVector;

    void Update()
    {
        transform.Rotate(rotationVector, speed * Time.deltaTime);
    }
}


