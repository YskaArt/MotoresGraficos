using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    

    public void Salir()
    {
        Application.Quit();

    }

    public void Reiniciar()
    {

        SceneManager.LoadScene(0);

    }
}
