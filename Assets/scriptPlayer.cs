using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptPlayer : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    public float vel = 5;
    public float pulo = 220;
    private bool chao = false, dir = true;
    private float x = 0;
    public LayerMask masc, finalizaJogo;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        chao = true;
        transform.parent = collision.transform;
    }

    private void OnCollisionExit2D (Collision2D collision) {
        chao = false;
    }

    // Update is called once per frame
    void Update()
    {
        pular(); mover(); animar(); rotacionar(); eliminarNPC(); gameOver();
    }

    private void mover() {
        x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel,rbd.velocity.y);
    }

    private void pular() {
        if (Input.GetKeyDown(KeyCode.Space) && chao) {
            chao = false;
            transform.parent = null;
            rbd.AddForce(new Vector2(0, pulo));
        }
    }

    private void animar() {
        if (x == 0) {
            anim.SetBool("Parado", true);
        } else {
            anim.SetBool("Parado", false);
        }
    }

    private void rotacionar() {
        //rotacionar
        if (dir && x < 0 || !dir && x > 0)
        {
            transform.Rotate(0, 180, 0);
            dir = !dir;
        }
    }

    private void eliminarNPC () {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, -transform.up, 0.8f, masc);
        if (hit.collider != null) {
            Destroy (hit.collider.gameObject);
        }
    }

    private void gameOver () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, 1, finalizaJogo);
        if (hit.collider != null) {
            SceneManager.LoadScene(2);
        }
        hit = Physics2D.Raycast(transform.position, transform.right, 0.4f, finalizaJogo);
         if (hit.collider != null) {
            SceneManager.LoadScene(2);
        }
    }
}
