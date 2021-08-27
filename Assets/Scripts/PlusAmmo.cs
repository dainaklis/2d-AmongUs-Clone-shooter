using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusAmmo : MonoBehaviour
{   
    

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
            AmmoText.ammoAmount += 10;
            Destroy(gameObject);
            SoundControl.sound.PlaySoundTakeAmmo();
        }

        
    }

   
}
