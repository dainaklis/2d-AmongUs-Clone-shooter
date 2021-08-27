using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{   

    [SerializeField] private GameObject bloodEffects;


    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMove>() != null)
        {
        
            

            Instantiate(bloodEffects, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);

            


        }

    }



}
