using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D rb2D;
    Animator anim;
    Vector2 mov;
    bool moving;
    SpriteRenderer sp;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
        mov.Normalize();

        sp.flipX = mov.x > 0;
        moving = mov != Vector2.zero;
        
        
        anim.SetBool("moving", moving);

    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + mov * speed * Time.deltaTime);
    }
}
