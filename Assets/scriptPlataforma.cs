using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlataforma : MonoBehaviour
{
    private float count = 0;
    public float vel = 5;
    private Vector2 posInicial;
    public float largura = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        count += vel * Time.deltaTime;
        float posX = Mathf.Cos(count) * largura;
        float posY = Mathf.Sin(count) * 0;

        Vector2 posAtual = new Vector2(posX, posY);
        transform.position = posInicial + posAtual;

        if (count >= 2 * Mathf.PI) {
            count = 2 * Mathf.PI - count;
        } 
    }
}
