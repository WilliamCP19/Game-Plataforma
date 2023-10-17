using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rdb;
    public float velocidade = 5f;
    public LayerMask mask, masc;
    
    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rdb.velocity = new Vector2(velocidade, 0); verificaColisao();
    }

    /*private void OnCollisionEnter2D (Collision2D collision) {
        Destroy (collision.gameObject);
    }*/

    private void verificaColisao () {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, transform.right, 0.5f, mask);
        if (hit.collider != null) {
            velocidade *= -1;
            rdb.velocity = new Vector2(velocidade, 0);
            transform.Rotate (new Vector2(0, 180));
        }

        hit = Physics2D.Raycast(transform.position, transform.right, 0.3f, masc);
        if (hit.collider != null) {
            SceneManager.LoadScene(2);
            Destroy(hit.collider.gameObject);
        }
    }
}