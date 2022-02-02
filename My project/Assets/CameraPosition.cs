using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public float distance;
    public Vector3 centerPoint;
    public Transform point1;
    public Transform point2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = (point1.position - point2.position).magnitude;
        centerPoint = (point1.position + point2.position) / 2f;

    }
}
