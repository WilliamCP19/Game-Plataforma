using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControlador : MonoBehaviour
{
    private bool pausado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (pausado) {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(0);
            } else {
                Time.timeScale = 0;
                SceneManager.LoadScene(0, LoadSceneMode.Additive);
            }
            pausado = !pausado;
        }
    }
}
