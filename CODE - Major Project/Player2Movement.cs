using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    private float directionX = 0f;
    [SerializeField] private float moveSpeedP2 = 7f;
    [SerializeField] private float jumpForceP2 = 14f;


    private enum P2MovementState { p2_idle, p2_running, p2_jumping, p2_falling}
    
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
        directionX = Input.GetAxisRaw("P2Horizontal");
        rb.velocity = new Vector2(directionX * moveSpeedP2, rb.velocity.y);


        if (Input.GetButtonDown("P2Vertical") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForceP2);
        }

        UpdateAnimationPlayer2();
    }

    private void UpdateAnimationPlayer2()
    {
        P2MovementState state;

        if (directionX > 0f)
        {
            state = P2MovementState.p2_running;
            sprite.flipX = false;
        }
        else if (directionX < 0f)
        {
            state = P2MovementState.p2_running;
            sprite.flipX = true;
        }
        else
        {
            state = P2MovementState.p2_idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = P2MovementState.p2_jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = P2MovementState.p2_falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
