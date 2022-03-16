 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Camera;
    public Transform point1;
    public Transform point2;
    public Vector3 centerPoint;
    public Vector3 cameraPlacement;
    public float distance;
    public float zoomFactor;
    public float minimum;
    public float maximum;

    //lets the camera calculate where to stay (including zooming), dependent on the position of both players
    void Update()
    {
        distance = (point1.position - point2.position).magnitude;
        centerPoint = (point1.position + point2.position) / 2f;
        zoomLimit();
        Camera.transform.position = cameraPlacement;
    
        
    }

    //tells at what distance from the players to stop zooming in and out
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

        if (distance > (maximum + 5) && gameManager.active)
        {
            gameManager.warning.SetActive(true);
        }
        if (distance < (maximum - 5) && gameManager.active)
        {
            gameManager.warning.SetActive(false);
        }
    }
}
