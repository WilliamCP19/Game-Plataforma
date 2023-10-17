using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject player;
    public float offset_y = 3;
    public float offset_x = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicao = new Vector3 (player.transform.position.x+offset_x,
                                        player.transform.position.y+offset_y, -10);
        this.transform.position = posicao;
    }
}
