using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject Player;
   
    public Camera _cam;
    public float sensitivity;
    public bool invertXAxis;
    public bool invertYAxis;

    public bool useLookAt;
    public Transform lookAt;

    void Start()
    {

        _cam.transform.parent = transform;
       

    }

    
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        
        h = (invertXAxis) ? (-h) : h;
        v = (invertYAxis) ? (-v) : v;

        
        if (h != 0)
        {   
             transform.Rotate(Vector3.up, h * 90 * sensitivity * Time.deltaTime);
            
        }
        if (v != 0)
        {   
            _cam.transform.RotateAround(transform.position, transform.right, v * 90 * sensitivity * Time.deltaTime);
        }
        
    }
}
