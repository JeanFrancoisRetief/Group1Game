using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    [Header("Global Script")]
    public int DialogueCounter;
    public int DayCounter;

    public GameObject Envornment1;
    public GameObject Envornment2;
    public GameObject Envornment3;
    public GameObject Envornment4;
    public GameObject Envornment5;

    public GameObject startText;

    [Header("Day 1")]
    public GameObject req1;
    public GameObject req2;
    public GameObject req3;

    [Header("Day 2")]
    public GameObject req4;
    public GameObject req5;
    public GameObject req6;
    public GameObject req7;

    [Header("Day 3")]
    public GameObject req8;
    public GameObject req9;
    public GameObject req10;
    public GameObject req11;
    public GameObject req12;
    public GameObject req13;

    [Header("Day 4")]
    public GameObject req14;
    public GameObject req15;
    public GameObject req16;
    public GameObject req17;
    public GameObject req18;
    public GameObject req19;

    [Header("Day 5")]
    public GameObject req20;
    public GameObject req21;
    public GameObject req22;
    public GameObject req23;
    public GameObject req24;
    public GameObject req25;
    public GameObject req26;
    public GameObject req27;
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

        req1.SetActive(true);
        req2.SetActive(true);
        req3.SetActive(true);

        req4.SetActive(false);
        req5.SetActive(false);
        req6.SetActive(false);
        req7.SetActive(false);

        req8.SetActive(false);
        req9.SetActive(false);
        req10.SetActive(false);
        req11.SetActive(false);
        req12.SetActive(false);
        req13.SetActive(false);

        req14.SetActive(false);
        req15.SetActive(false);
        req16.SetActive(false);
        req17.SetActive(false);
        req18.SetActive(false);
        req19.SetActive(false);

        req20.SetActive(false);
        req21.SetActive(false);
        req22.SetActive(false);
        req23.SetActive(false);
        req24.SetActive(false);
        req25.SetActive(false);
        req26.SetActive(false);
        req27.SetActive(false);
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

        req1.SetActive(false);
        req2.SetActive(false);
        req3.SetActive(false);

        req4.SetActive(true);
        req5.SetActive(true);
        req6.SetActive(true);
        req7.SetActive(true);

        req8.SetActive(false);
        req9.SetActive(false);
        req10.SetActive(false);
        req11.SetActive(false);
        req12.SetActive(false);
        req13.SetActive(false);

        req14.SetActive(false);
        req15.SetActive(false);
        req16.SetActive(false);
        req17.SetActive(false);
        req18.SetActive(false);
        req19.SetActive(false);

        req20.SetActive(false);
        req21.SetActive(false);
        req22.SetActive(false);
        req23.SetActive(false);
        req24.SetActive(false);
        req25.SetActive(false);
        req26.SetActive(false);
        req27.SetActive(false);
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

        req1.SetActive(false);
        req2.SetActive(false);
        req3.SetActive(false);

        req4.SetActive(false);
        req5.SetActive(false);
        req6.SetActive(false);
        req7.SetActive(false);

        req8.SetActive(true);
        req9.SetActive(true);
        req10.SetActive(true);
        req11.SetActive(true);
        req12.SetActive(true);
        req13.SetActive(true);

        req14.SetActive(false);
        req15.SetActive(false);
        req16.SetActive(false);
        req17.SetActive(false);
        req18.SetActive(false);
        req19.SetActive(false);

        req20.SetActive(false);
        req21.SetActive(false);
        req22.SetActive(false);
        req23.SetActive(false);
        req24.SetActive(false);
        req25.SetActive(false);
        req26.SetActive(false);
        req27.SetActive(false);
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

        req1.SetActive(false);
        req2.SetActive(false);
        req3.SetActive(false);

        req4.SetActive(false);
        req5.SetActive(false);
        req6.SetActive(false);
        req7.SetActive(false);

        req8.SetActive(false);
        req9.SetActive(false);
        req10.SetActive(false);
        req11.SetActive(false);
        req12.SetActive(false);
        req13.SetActive(false);

        req14.SetActive(true);
        req15.SetActive(true);
        req16.SetActive(true);
        req17.SetActive(true);
        req18.SetActive(true);
        req19.SetActive(true);

        req20.SetActive(false);
        req21.SetActive(false);
        req22.SetActive(false);
        req23.SetActive(false);
        req24.SetActive(false);
        req25.SetActive(false);
        req26.SetActive(false);
        req27.SetActive(false);
    }

    public void SwitchDay5ToDay6()
    {
        DialogueCounter = 0;
        DayCounter = 6;

        req1.SetActive(false);
        req2.SetActive(false);
        req3.SetActive(false);

        req4.SetActive(false);
        req5.SetActive(false);
        req6.SetActive(false);
        req7.SetActive(false);

        req8.SetActive(false);
        req9.SetActive(false);
        req10.SetActive(false);
        req11.SetActive(false);
        req12.SetActive(false);
        req13.SetActive(false);

        req14.SetActive(false);
        req15.SetActive(false);
        req16.SetActive(false);
        req17.SetActive(false);
        req18.SetActive(false);
        req19.SetActive(false);

        req20.SetActive(true);
        req21.SetActive(true);
        req22.SetActive(true);
        req23.SetActive(true);
        req24.SetActive(true);
        req25.SetActive(true);
        req26.SetActive(true);
        req27.SetActive(true);
    }
}
