using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptGameOver : MonoBehaviour
{
    public void voltarMenu () {
        SceneManager.LoadScene(0);
    }
}
