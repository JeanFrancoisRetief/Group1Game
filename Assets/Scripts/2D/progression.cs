using System.Collections;
using System.Collections.Generic;
using Unity.XR.GoogleVr;
using UnityEngine;

public class progression : MonoBehaviour
{
    [Header("Misc")]
    public playerStats playerStats;

    [Header("Day One")]
    public GameObject crop1;
    public GameObject chickenCoop1;

    [Header("Day Two")]
    public GameObject crop2;
    public GameObject cowBarn1;

    [Header("Day Three")]
    public GameObject chickenCoop2;
    public GameObject silo;
    public GameObject transport;
    public GameObject composter;

    [Header("Day Four")]
    public GameObject crop3;
    public GameObject crop4;
    public GameObject cowBarn2;
    public GameObject greenhouse;
    public GameObject shop;

    private void Start()
    {
        //day one
        crop1.SetActive(false);
        chickenCoop1.SetActive(false);

        //day two
        crop2.SetActive(false);
        cowBarn1.SetActive(false);

        //day three
        chickenCoop2.SetActive(false);
        silo.SetActive(false);
        transport.SetActive(false);
        composter.SetActive(false);

        //day four + five
        crop3.SetActive(false);
        crop4.SetActive(false);
        cowBarn2.SetActive(false);
        greenhouse.SetActive(false);
        shop.SetActive(false);
    }

    private void Update()
    {
        if (playerStats.day == 1)
        {
            //day one
            crop1.SetActive(true);
            chickenCoop1.SetActive(true);
        }

        if (playerStats.day == 2)
        {
            //day one
            crop1.SetActive(true);
            chickenCoop1.SetActive(true);

            //day two
            crop2.SetActive(true);
            cowBarn1.SetActive(true);
            silo.SetActive(true);
        }

        if (playerStats.day == 3)
        {
            //day one
            crop1.SetActive(true);
            chickenCoop1.SetActive(true);

            //day two
            crop2.SetActive(true);
            cowBarn1.SetActive(true);
            silo.SetActive(true);

            //day three
            chickenCoop2.SetActive(true);
            transport.SetActive(true);
            composter.SetActive(true);
        }

        if (playerStats.day == 4)
        {
            //day one
            crop1.SetActive(true);
            chickenCoop1.SetActive(true);

            //day two
            crop2.SetActive(true);
            cowBarn1.SetActive(true);
            silo.SetActive(true);

            //day three
            chickenCoop2.SetActive(true);
            transport.SetActive(true);
            composter.SetActive(true);

            //day four + five
            crop3.SetActive(true);
            crop4.SetActive(true);
            cowBarn2.SetActive(true);
            greenhouse.SetActive(true);
            shop.SetActive(true);
        }

        if (playerStats.day == 5)
        {
            //day one
            crop1.SetActive(true);
            chickenCoop1.SetActive(true);

            //day two
            crop2.SetActive(true);
            cowBarn1.SetActive(true);
            silo.SetActive(true);

            //day three
            chickenCoop2.SetActive(true);
            transport.SetActive(true);
            composter.SetActive(true);

            //day four + five
            crop3.SetActive(true);
            crop4.SetActive(true);
            cowBarn2.SetActive(true);
            greenhouse.SetActive(true);
            shop.SetActive(true);
        }
    }
}
