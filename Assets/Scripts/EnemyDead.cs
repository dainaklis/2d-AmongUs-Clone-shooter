using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDead : MonoBehaviour
{
    private Rigidbody2D rbEnemy;
    private float kill;

    void Start()
    {
        rbEnemy =GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            kill++;
        }
    }
}
