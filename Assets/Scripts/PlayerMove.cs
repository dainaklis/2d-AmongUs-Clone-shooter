using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   

    //  -------------- JUDEJIMAS PC ----------------------------
    private Rigidbody2D rbPlayer;
    private Animator anim;

    private float dirX, dirY, moveSpeed;
    private Vector3 localScale;

    // ------------------------------------------------------------





    
void Start()
    {
        rbPlayer =GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        

        moveSpeed = 5f;

        localScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -25f, 18f), 
            Mathf.Clamp(transform.position.y, -8f, 8f)
        );

 
        AnimationControl();

    }

    private void FixedUpdate()
    {
        rbPlayer.velocity = new Vector2(dirX, dirY);

    }

    private void LateUpdate()
    {
        if (rbPlayer.velocity.x > 0)
        {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if (rbPlayer.velocity.x < 0)
        {
            transform.localScale = new Vector3( - localScale.x, localScale.y, localScale.z);
        }
    }


    private void AnimationControl()
    {
        if (rbPlayer.velocity.y == 0 && rbPlayer.velocity.x == 0)
        {
            anim.Play("PlayerIdle");
        }
        if (rbPlayer.velocity.x != 0 || rbPlayer.velocity.y != 0)
        {
            anim.Play("PlayerRun");
        }
    }





}
