using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    private Text text;
    public static int ammoAmount = 10;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ammoAmount > 0)
        {
            text.text = "Ammo: " + ammoAmount;
        }
        else
        {
            text.text = "Nera AMMO !";
        }
    }
}
