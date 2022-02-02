 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Camera;
    public Transform point1;
    public Transform point2;
    public Vector3 centerPoint;
    public Vector3 cameraPlacement;
    public float distance;
    public float zoomFactor;

    public float minimum;
    public float maximum;

    void Start()
    {

    }

    void Update()
    {
        distance = (point1.position - point2.position).magnitude;
        centerPoint = (point1.position + point2.position) / 2f;
        zoomLimit();
        Camera.transform.position = cameraPlacement;
    
        
    }

    public void zoomLimit()
    {
            cameraPlacement = centerPoint - Camera.transform.forward * distance * zoomFactor;
        if (distance < minimum)
        {
            cameraPlacement = centerPoint - Camera.transform.forward * minimum * zoomFactor;
        }
        else if (distance > maximum)
        {
            cameraPlacement = centerPoint - Camera.transform.forward * maximum * zoomFactor;
        }
    }
}
