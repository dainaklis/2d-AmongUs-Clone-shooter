using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TESTSAVE : MonoBehaviour
{
    public static TESTSAVE tESTSAVE;
    [SerializeField] private Text test1Text;

    

    public int number;

    public int issaugotaPasdaudimu;

    public int ATSVISO;



    private void Awake()
    {
        tESTSAVE = this;
    }


    void Start()
    {
        test1Text.text = "Paspaudimu sk: " + number;
        ATSVISO = PlayerPrefs.GetInt("numberSaveMAX");

        //issaugotaPasdaudimu = PlayerPrefs.GetInt("numberSave");
        //DuodaRezultata();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            number++;

            PlayerPrefs.SetInt("numberSave", number);

            test1Text.text = "Paspaudimu sk: " + number;
            
        }


        if (Input.GetKeyDown("n"))
        {
            SceneManager.LoadScene("Level3");
        }

    }

    public int DuodaRezultataATS()
    {
        return number;
    }


}
