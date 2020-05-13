using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTriangleTwo : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -30f) * Time.deltaTime); // Time.delatTime for same speed on any device
    }
}
