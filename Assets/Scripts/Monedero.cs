using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monedero : MonoBehaviour
{
    public Score Sumarscore;
    [SerializeField] private GameObject Jezzubloqueo;

    private void OnTriggerEnter(Collider Toque)
    {
        if (Toque.gameObject.CompareTag("Points"))
        {
            Sumarscore.Contador(10);
            Destroy(Toque.gameObject);

        }
    }
    void Update()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Points");
        if (bricks.Length == 0)
        {
            Jezzubloqueo.SetActive(false);
        }
    }
}
