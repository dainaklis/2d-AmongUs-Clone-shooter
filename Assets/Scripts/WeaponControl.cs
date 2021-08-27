using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    private int wichWeaponSelected;
    private GameObject weapon;


    
    void Start()
    {
        wichWeaponSelected = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            print("Pradzia: " + wichWeaponSelected);
            SwitchWeapon();
        }
    }

    private void SwitchWeapon()
    {
        switch (wichWeaponSelected)
        {
            
            case 1:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }

                weapon = Instantiate(Resources.Load("Prefabs/Pistol_"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(2.14f,-0.66f,0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = Vector3.one;
                wichWeaponSelected += 1;
                print("Pistol: " + wichWeaponSelected);
                break;

            case 2:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }

                weapon = Instantiate(Resources.Load("Prefabs/Shotgun_"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.9f,-0.66f,0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = Vector3.one;
                wichWeaponSelected += 1;
                print("M3: " + wichWeaponSelected);
                break;

            case 3:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }

                weapon = Instantiate(Resources.Load("Prefabs/AK47_"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(1.87f,-0.62f,0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = new Vector3(-3f,3f,0f);
                wichWeaponSelected += 1;
                print("AK47: " + wichWeaponSelected);
                break;
        }

        if (wichWeaponSelected > 3)
        {
            wichWeaponSelected = 1;

        }
    }
}
