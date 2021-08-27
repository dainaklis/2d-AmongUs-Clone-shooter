using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    // --- Enemy seka Player is ZOTOV -----------------------------
    private Rigidbody2D rbEnemy;
    private PlayerMove player;
    private Animator animm;

    private float  moveSpeed = 2f;
    private Vector3 localScale;
    private Vector3 directionToPlayer;

    




    void Start()
    {
        rbEnemy =GetComponent<Rigidbody2D>();
        player = FindObjectOfType(typeof(PlayerMove)) as PlayerMove;
        
        animm = GetComponent<Animator>();
        

        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {



        AnimationControl();
    }

    private void FixedUpdate()
    {
        if (player == null)
        {
            return;
        }
        
        MoveEnemy();
    }


    private void LateUpdate()
    {
        if (rbEnemy.velocity.x > 0)
        {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if (rbEnemy.velocity.x < 0)
        {
            transform.localScale = new Vector3( - localScale.x, localScale.y, localScale.z);
        }
    }

    // -------------------------------------------------------------------------------------------------------------
    private void MoveEnemy()
    {
        directionToPlayer = (player.transform.position - transform.position).normalized;
        rbEnemy.velocity = new Vector2(directionToPlayer.x, directionToPlayer.y) * moveSpeed;

    }


    private void AnimationControl()
    {
        if (rbEnemy.velocity.y == 0 && rbEnemy.velocity.x == 0)
        {
            animm.Play("EnemyIdle");
        }
        if (rbEnemy.velocity.x != 0 || rbEnemy.velocity.y != 0)
        {
            animm.Play("EnemyRun");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            SoundControl.sound.PlaySoundHitEnemy();
        }
    }
}
