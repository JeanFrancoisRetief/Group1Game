using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public int DialogueCounter;
    public int DayCounter;

    public GameObject Envornment1;
    public GameObject Envornment2;
    public GameObject Envornment3;
    public GameObject Envornment4;
    public GameObject Envornment5;
    //public int InteractCounter;
    // Start is called before the first frame update
    void Start()
    {
        DialogueCounter = 0;
        //InteractCounter = 0;
        DayCounter = 1;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchDay1ToDay2()
    {
        DialogueCounter = 0;
        DayCounter = 2;

        Envornment1.SetActive(false);
        Envornment2.SetActive(true);
        Envornment3.SetActive(false);
        Envornment4.SetActive(false);
        Envornment5.SetActive(false);
    }

    public void SwitchDay2ToDay3()
    {
        DialogueCounter = 0;
        DayCounter = 3;

        Envornment1.SetActive(false);
        Envornment2.SetActive(false);
        Envornment3.SetActive(true);
        Envornment4.SetActive(false);
        Envornment5.SetActive(false);
    }

    public void SwitchDay3ToDay4()
    {
        DialogueCounter = 0;
        DayCounter = 4;

        Envornment1.SetActive(false);
        Envornment2.SetActive(false);
        Envornment3.SetActive(false);
        Envornment4.SetActive(true);
        Envornment5.SetActive(false);
    }

    public void SwitchDay4ToDay5()
    {
        DialogueCounter = 0;
        DayCounter = 5;

        Envornment1.SetActive(false);
        Envornment2.SetActive(false);
        Envornment3.SetActive(false);
        Envornment4.SetActive(false);
        Envornment5.SetActive(true);
    }
}
