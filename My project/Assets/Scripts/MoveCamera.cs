 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameManager gameManager;
    public Camera physicalCamera;
    public Transform point1;
    public Transform point2;
    public Vector3 centerPoint;
    public Vector3 cameraPlacement;
    public float distance;
    public float speed;
    public float zoom;
    public float minimum;
    public float maximum;
    public bool tooFar;

    void Start()
    {
        tooFar = false;
    }

    void Update()
    {
        distance = (point1.position - point2.position).magnitude;
        centerPoint = (point1.position + point2.position) / 2f;
        cameraPlacement = centerPoint - physicalCamera.transform.forward * distance * zoom;
        zoomLimit();
   
        physicalCamera.transform.position = cameraPlacement;
    
        
    }

    public void zoomLimit()
    {
        if (distance <= minimum)
        {
            cameraPlacement = centerPoint - physicalCamera.transform.forward * minimum * zoom;
        }
        else if (distance >= maximum)
        {
            cameraPlacement = centerPoint - physicalCamera.transform.forward * maximum * zoom;
        }

        if (distance >= (maximum + 5))
        {
            gameManager.warning.SetActive(true);
            tooFar = true;
        }
        if ((distance <= (maximum - 5)) && (tooFar = true))
        {
            gameManager.warning.SetActive(false);
            tooFar = false;
        }
    }
}
