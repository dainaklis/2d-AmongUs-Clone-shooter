using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{   
    private Rigidbody2D rbPlayer;
    [SerializeField] private SpriteRenderer spPlayer, spAkiniai, spSeselys;
    [SerializeField] private GameObject fireExplotion;

    [SerializeField] private GameObject heart1, heart2, heart3, gameOver;

    public int healt = 3;

    void Start()
    {
        rbPlayer =GetComponent<Rigidbody2D>();
        
        Time.timeScale = 1;

        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Enemy")
        {
            healt --;

            SoundControl.sound.PlaySoundHit();
            StartCoroutine(PlayerBlink());

            switch (healt)
            {
                case 3:
                    heart1.SetActive(true);
                    heart2.SetActive(true);
                    heart3.SetActive(true);
                    break;

                case 2:
                    heart1.SetActive(true);
                    heart2.SetActive(true);
                    heart3.SetActive(false);
                    break;

                case 1:
                    heart1.SetActive(true);
                    heart2.SetActive(false);
                    heart3.SetActive(false);
                    break;

                case 0:
                    heart1.SetActive(false);
                    heart2.SetActive(false);
                    heart3.SetActive(false);
                    Destroy(gameObject);
                    SoundControl.sound.PlaySoundGameOver();
                    Instantiate(fireExplotion, transform.position,transform.rotation); 
                    gameOver.SetActive(true);
                    Time.timeScale = 0;
                    break;
                
                
            }

            // if (healt == 0)
            // {
            //    Destroy(gameObject);
            //     Instantiate(fireExplotion, transform.position,transform.rotation); 
            // }
            
        }
    }



     IEnumerator PlayerBlink()
         {

            for (int i = 0; i < 10; i++)
            {
                spPlayer.enabled = false;
                spAkiniai.enabled = false;
                spSeselys.enabled = false;

                yield return new WaitForSeconds (0.0833f);

                spPlayer.enabled = true;
                spAkiniai.enabled = true;
                spSeselys.enabled = true;

                yield return new WaitForSeconds (0.0833f);
            }
             

         }
}
