using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TESTSAVE2 : MonoBehaviour
{   
    public static TESTSAVE2 tESTSAVE2;
    [SerializeField] private Text test2Text;

    public int number;

    public int ATSisTEST1;

    public int ATSVISO;



    private void Awake()
    {
        tESTSAVE2 = this;
    }

    void Start()
    {
        //gaunam info is TEST1, number skaiciu.
        ATSisTEST1 = TESTSAVE.tESTSAVE.DuodaRezultataATS();
        // number sk atvaizduojam
        test2Text.text = "Isviso paspaudimu: " + ATSisTEST1;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            ATSisTEST1++;

            test2Text.text = "Isviso paspaudimu: " + ATSisTEST1;


            ATSVISO = PlayerPrefs.GetInt("numberSaveMAX");

            if (ATSVISO < ATSisTEST1)
            {
                PlayerPrefs.SetInt("numberSaveMAX", ATSisTEST1);
            }

        }
        
    }
}
