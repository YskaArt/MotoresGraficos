using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedero : MonoBehaviour
{
    public Score Sumarscore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Toque)
    {
        if (Toque.gameObject.CompareTag("Points"))
        {
            Sumarscore.Contador(10);
            Destroy(Toque.gameObject);

        }
    }
}
