using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptInicio : MonoBehaviour
{
    public void inciar() {
        SceneManager.LoadScene(1);
    }

    public void sair() {
        Application.Quit();
    }
}
