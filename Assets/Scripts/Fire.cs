using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public static Fire fire;
    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private Transform barrel;
    private float bulletSpeed = 500f;

    [SerializeField] private float fireRatePistol = 0.5f;
    [SerializeField] private float fireRateShotgun = 1f;
    [SerializeField] private float fireRateAK47 = 0.02f;
    private float nextFire = 0f;


    string currentWeaponName;


    void Awake()
    {
        fire = this;
    }

    void Start()
    {
        currentWeaponName = gameObject.name.Substring(0, name.IndexOf("_")); 
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && AmmoText.ammoAmount > 0 && Time.time > nextFire )
        {
        
            WeaponFire(currentWeaponName);
        }

        if (Input.GetKey(KeyCode.R) && AmmoText.ammoAmount == 0)
        {
            //---------bullet RELOAD from ZOTOV -------------------
            AmmoText.ammoAmount = 10;
            SoundControl.sound.PlaySoundTakeAmmo();

        }

        if (Input.GetButtonDown("Fire1") && AmmoText.ammoAmount == 0)
        {
            SoundControl.sound.PlaySoundAmmmoOut();
            
        }
    }

    private void WeaponFire(string weaponName)
    {
        if (weaponName == "Pistol")
        {
            AmmoText.ammoAmount -= 1;

            nextFire = Time.time + fireRatePistol;


            var spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnBullet.AddForce(barrel.up * bulletSpeed);
            SoundControl.sound.PlaySoundPistol();


        }

        if (weaponName == "AK47")
        {
            AmmoText.ammoAmount -= 1;

            nextFire = Time.time + fireRateAK47;


            var spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnBullet.AddForce(barrel.up * bulletSpeed);
            SoundControl.sound.PlaySoundAK47();


        }

        else if (weaponName == "Shotgun")
        {   

            AmmoText.ammoAmount -= 1;

            nextFire = Time.time + fireRateShotgun;

            for (int i = 0; i <= 2; i++)
            {
                    var spawnBullet = Instantiate(bullet, barrel.position, barrel.rotation);
                    SoundControl.sound.PlaySoundShotgunl();


                    switch (i)
                    {
                        case 0:
                            spawnBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, -90f, 0f));
                            break;

                        case 1:
                            spawnBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, 0f, 0f));
                            break;

                        case 2:
                            spawnBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, 90f, 0f));
                            break;
                    } 

            }
            
        }
        
        
    }
}
