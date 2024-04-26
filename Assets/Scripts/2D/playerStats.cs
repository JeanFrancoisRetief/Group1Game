using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    [Header("Player Stats")]
    public int lvl;
    public Text lvlTxt;
    public int xp;
    public int xpLimit;
    public Slider sldXP;
    public int coins;
    public Text coinsTxt;
    public float time;
    public Text timeTxt;
    public int day;
    public Text dayTxt;

    [Header("Crop Stats")]
    public int wheatAmt;
    public Text wheatAmtTxt;
    public int cornAmt;
    public Text cornAmtTxt;
    public int riceAmt;
    public Text riceAmtTxt;

    public GameObject statsMenu;

    [Header("Requests")]
    public int reqPending;
    public Text reqPendingTxt;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 0;
        xp = 0;
        xpLimit = 10;
        coins = 10;
        day = 1;
        time = 1;
        reqPending = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dayTxt.text = "Day: " + day;
        timeTxt.text = "Time: " + time;

        sldXP.value = xp;
        sldXP.maxValue = xpLimit;
        lvlTxt.text = "Lvl: " + lvl;

        coinsTxt.text = "Coins: " + coins;

        if (xp >= xpLimit)
        {
            xp = 0;

            xpLimit = xpLimit * 2;

            lvl = lvl + 1;
        }

        wheatAmtTxt.text = "Wheat: " + wheatAmt;
        cornAmtTxt.text = "Corn: " + cornAmt;
        riceAmtTxt.text = "Rice: " + riceAmt;

        reqPendingTxt.text = "Req Pending: " + reqPending;

        //time of day
        //if (time > 0)
        //{
        //    time += Time.deltaTime;
        //}
        //else if (time < 0)
        //{
        //    time = 0;
        //}
        //int minutes = Mathf.FloorToInt(time / 60);
        //int seconds = Mathf.FloorToInt(time % 60);
        //timeTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void statsMenuDropDown()
    {
        if (statsMenu == false)
        {
            statsMenu.SetActive(true);
        }
    }
}
