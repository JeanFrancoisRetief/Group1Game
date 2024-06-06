using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public int stringNo;
    public string stgMayorBrown;
    public string stgplayer;
    public string stgMrFarmsbury;
    public string mayorBrown;
    public Text txtMayorBrown;
    public Text txtPlayer;
    //public Text txtMrFarmsbury;

    public GameObject majorBrown;
    public GameObject player;
    //public GameObject mrFarmsbury;


    private void Start()
    {
        stringNo = 1;
        majorBrown.SetActive(false);
        player.SetActive(false);
    }

    private void Update()
    {
        txtMayorBrown.text = stgMayorBrown;
        txtPlayer.text = stgplayer;
        //txtMrFarmsbury.text = stgMrFarmsbury;

        if (stringNo == 1)
        {
            majorBrown.SetActive(true);
            stgMayorBrown = "\tMajor Brown\r\nHey! Hey!\r\nIt is oh so terrible what the tornado has done to our lil town.";
        }

        if (stringNo == 2)
        {
            stgMayorBrown = "\tMajor Brown\r\nIt destroyed most of our houses, the farm your father left to you too and on your FIRST day of ownership. Oh, so sad Farmsbury Jnr.";
        }

        if (stringNo == 3)
        {
            stgMayorBrown = "\tMajor Brown\r\nWe must rebuild our homes, and you, your farm... but we'll need sustenance to do so. Will you help?";
        }

        if (stringNo == 4)
        {
            player.SetActive(true);
            majorBrown.SetActive(false);

            stgplayer = "\tFarmsbury Jnr.\r\nYes. I shall speak to my father quickly, he was to leave today.";
        }

        if (stringNo == 5)
        {
            stgplayer = "\tFarmsbury Jnr.\r\nDad? Dad?";
        }

        if (stringNo == 6)
        {
            player.SetActive(false);
        }
    }

    public void nextText()
    {
        stringNo = stringNo + 1;
    }
}
