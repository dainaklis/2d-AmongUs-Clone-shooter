using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{   
    public static SoundControl sound;
    private AudioSource audioSrc;
    [SerializeField] private AudioClip soundPistol, soundShotgun, soundAK, ammoOut, takeAmmo, soundHit, soundHitEnemy, soundGameOver;


    private void Awake() 
    {
        sound = this;

    }
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySoundPistol()
    {
        audioSrc.PlayOneShot(soundPistol);
    
    }

    public void PlaySoundShotgunl()
    {
        audioSrc.PlayOneShot(soundShotgun);
    }

    public void PlaySoundAK47()
    {
        audioSrc.PlayOneShot(soundAK);
    }

    public void PlaySoundAmmmoOut()
    {
        audioSrc.PlayOneShot(ammoOut);
        //StartCoroutine(PlayAndStop());
        
    }

    public void PlaySoundTakeAmmo()
    {
        audioSrc.PlayOneShot(takeAmmo);
    }

    public void PlaySoundHit()
    {
        audioSrc.PlayOneShot(soundHit);
    }

    public void PlaySoundHitEnemy()
    {
        audioSrc.PlayOneShot(soundHitEnemy);
    }

    public void PlaySoundGameOver()
    {
        audioSrc.PlayOneShot(soundGameOver);
    }


    // IEnumerator PlayAndStop()
    //     {
    //         audioSrc.PlayOneShot(ammoOut);
            
    //         //yield return new WaitForSeconds (1f);

    //         //audioSrc.Stop();
    //     }



    //------------------- VEIKIA sitas------------------------------------
    //  PVZ ------------- SoundManager.PlaySound("soundPistolShoot");

    // public static AudioClip soundPistolShoot, soundShotgunShoot;
    // static AudioSource audioSrc;

    // void Start()
    // {
    //     soundPistolShoot = Resources.Load<AudioClip>("Gun1_2");
    //     soundShotgunShoot = Resources.Load<AudioClip>("Gun1_2");

    //     audioSrc = GetComponent<AudioSource>();
    // }

    // public static void PlaySound(string clip)
    // {
    //     switch (clip)
    //     {
    //         case "soundPistolShoot":
    //             audioSrc.PlayOneShot(soundPistolShoot);
    //             break;
    //         case "soundShotgunShoot":
    //             audioSrc.PlayOneShot(soundShotgunShoot);
    //             break;
    //       
    //         case "stop":
    //             audioSrc.Stop();
    //             break;
            
    //     }
    // }
}
