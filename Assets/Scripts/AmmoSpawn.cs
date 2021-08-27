using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawn : MonoBehaviour
{
[SerializeField] private Transform ammo;
    
    void Start()
    {
        //SpawnAmmo();
        
        InvokeRepeating("SpawnAmmo", 0f, 10f);


        
    }

    private void SpawnAmmo()
    {   
        
        //if (GameObject.FindWithTag("Ammo") == null)
        if (AmmoText.ammoAmount == 0)
        {
            Vector3 ammoSpawnPosition = new Vector3(Random.Range(-25f, 15f),Random.Range(-1f, -2f), 0f);

            Instantiate(ammo, ammoSpawnPosition, Quaternion.identity);
            

            
            // bool ammoSpawn = false;
            // while(!ammoSpawn)
            // {
            //     Vector3 ammoSpawnPosition = new Vector3(Random.Range(-25f, 15f),Random.Range(-1f, -2f), 0f);
            //     if ((ammoSpawnPosition - transform.position).magnitude < 3)
            //     {
            //         continue;
            //     }
            //     else
            //     {
            //         Instantiate(ammo, ammoSpawnPosition, Quaternion.identity);
            //         ammoSpawn = true;
            //     }
            // }
        }
        
    }

}
