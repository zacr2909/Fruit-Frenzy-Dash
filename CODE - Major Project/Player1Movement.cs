using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    private float directionX = 0f;
    [SerializeField] private float moveSpeedP1 = 7f;
    [SerializeField] private float jumpForceP1 = 14f;

    private enum P1MovementState { p1_idle, p1_running, p1_jumping, p1_falling}

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxisRaw("P1Horizontal");
        rb.velocity = new Vector2(directionX * moveSpeedP1, rb.velocity.y);


        if (Input.GetButtonDown("P1Vertical") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForceP1);
        }

        UpdateAnimationStatePlayer1();
    }

    private void UpdateAnimationStatePlayer1()
    {
        P1MovementState state;

        if (directionX > 0f)
        {
            state = P1MovementState.p1_running;
            sprite.flipX = false;
        }
        else if (directionX < 0f)
        {
            state = P1MovementState.p1_running;
            sprite.flipX = true;
        }
        else
        {
            state = P1MovementState.p1_idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = P1MovementState.p1_jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = P1MovementState.p1_falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
