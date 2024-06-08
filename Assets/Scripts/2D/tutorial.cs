using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    [Header("Overall")]
    public int stringNo;
    public playerStats playerStats;

    [Header("Intro")]
    public string stgMayorBrown;
    public string stgplayer;
    public Text txtMayorBrown;
    public Text txtPlayer;

    public GameObject majorBrown;
    public GameObject player;
    public GameObject pnlIntro;

    [Header("Tutorial")]
    public GameObject pnlTutorial;
    public string stgMrFarmsbury;
    public GameObject mrFarmsbury;
    public Text txtMrFarmsbury;

    public GameObject pnlRequests;
    public GameObject pnlStats;

    private void Start()
    {
        stringNo = 1;
        majorBrown.SetActive(false);
        player.SetActive(false);
        pnlIntro.SetActive(false);

        pnlTutorial.SetActive(false);
        mrFarmsbury.SetActive(false);
    }

    private void Update()
    {
        txtMayorBrown.text = stgMayorBrown;
        txtPlayer.text = stgplayer;
        txtMrFarmsbury.text = stgMrFarmsbury;

        if (stringNo == 1)
        {
            pnlIntro.SetActive(true);
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
            pnlIntro.SetActive(false);
            player.SetActive(false);

            pnlTutorial.SetActive(true);
            mrFarmsbury.SetActive(true);
            stgMrFarmsbury = "\tMr. Farmsbury\r\nYes, yes. Let me show you around. Up above show's your LEVEL. When you LEVEL up, you will earn GEMS.";
        }

        if (stringNo == 7)
        {
            stgMrFarmsbury = "\tMr. Farmsbury\r\nSpend your GEMS wisely! They're rare to find in our town.";
        }

        if (stringNo == 8)
        {
            stgMrFarmsbury = "\tMr. Farmsbury\r\nOn the left, of the LEVEL BAR, is how much COINS and GEMS our- sorry, your farm has.";
        }

        if (stringNo == 9)
        {
            stgMrFarmsbury = "\tMr. Farmsbury\r\nOh! Seems like Mayor Brown has sent a REQUEST through. Let's see what he wants. Press the BLUE REQUEST button on the bottom right and ACCEPT the first REQUEST.";
        }

        if (stringNo == 10)
        {
            pnlTutorial.SetActive(false);
        }

        if (stringNo == 10 && playerStats.reqPending >= 1)
        {
            StartCoroutine(AfterOpenRequests());
        }

        if (stringNo == 12)
        {
            pnlTutorial.SetActive(false);
        }

        if (stringNo == 12 && pnlStats == true)
        {
            StartCoroutine(AfterOpenStats());
        }

        if (stringNo == 14)
        {
            pnlTutorial.SetActive(false);
        }

        if (stringNo == 14 && playerStats.wheatAmt >= 25)
        {
            StartCoroutine(EnoughWheat());
        }

        if (stringNo == 16)
        {
            pnlTutorial.SetActive(false);
        }

        if (stringNo == 16 && playerStats.reqPending <= 0)
        {
            StartCoroutine(FulfilledRequest());
        }

        if (stringNo == 18)
        {
            stgMrFarmsbury = "\tMr. Farmsbury\r\nThe next REQUESTOR asks for 20 RICE and 3 EGGS. \r\nYou currently have 1 CHICKEN COOP after the tornado. Press the RED ARROW button next to the COOP to buy another CHICKEN or UPGRADE the COOP it.\r\nYou do not have enough EGGS. Owning 2 or more CHICKENS will start the production of EGGS.";
        }

        if (stringNo == 19)
        {
            stgMrFarmsbury = "\tMr. Farmsbury\r\nThat's the gist of it my child. It is time I take my leave and enter retirement. Goodbye...";
            pnlTutorial.SetActive(false);
        }
    }

    public void nextText()
    {
        stringNo = stringNo + 1;
    }

    public IEnumerator AfterOpenRequests()
    {
        yield return new WaitForSeconds(2f);

        stringNo = 11;

        pnlTutorial.SetActive(true);
        stgMrFarmsbury = "\tMr. Farmsbury\r\nHe wants 25 WHEAT.\r\nLet's go see how much you have. Exit the REQUEST MENU and press the ORANGE button in the TOP RIGHT CORNER. This will show all your RESOURCES and how much of each you can hold.";
    }

    public IEnumerator AfterOpenStats() 
    {
        yield return new WaitForSeconds(2f);

        stringNo = 13;

        pnlTutorial.SetActive(true);
        stgMrFarmsbury = "\tMr. Farmsbury\r\nYou don't have enough! Exit the RESOURCES LIST and let's make more WHEAT. Press the first CROP PLOT and select WHEAT to GROW more. We must wait for the CROP to GROW so we can HARVEST it.";
    }

    public IEnumerator EnoughWheat()
    {
        yield return new WaitForSeconds(2f);

        stringNo = 15;

        pnlTutorial.SetActive(true);
        stgMrFarmsbury = "\tMr. Farmsbury\r\nNow that we have enough WHEAT, let's fulfil the REQUEST. Go back to the REQUEST MENU and send the RESOURCES through.";
    }

    public IEnumerator FulfilledRequest()
    {
        yield return new WaitForSeconds(2f);

        stringNo = 17;

        pnlTutorial.SetActive(true);
        stgMrFarmsbury = "\tMr. Farmsbury\r\nAs you can see, you earn COINS and XP for fulfilling REQUESTS.";
    }
}
