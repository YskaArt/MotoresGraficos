using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset;
    void Start()
    {
        
        offset = transform.position - Player.transform.position;

    }

    
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
