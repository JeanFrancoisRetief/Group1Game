using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.MPE;
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
    public int maxWheatAmt;
    public Text wheatAmtTxt;
    public int cornAmt;
    public int maxCornAmt;
    public Text cornAmtTxt;
    public int riceAmt;
    public int maxRiceAmt;
    public Text riceAmtTxt;

    public GameObject statsMenu;

    [Header("Chickens")]
    public int chickenAmt;
    public int maxChickenAmt;
    public Text chickenAmtTxt;
    public int eggsAmt;
    public int maxEggsAmt;
    public Text eggsAmtTxt;

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

        //crops
        wheatAmtTxt.text = "Wheat: " + wheatAmt + "/" + maxWheatAmt;
        cornAmtTxt.text = "Corn: " + cornAmt + "/" + maxCornAmt;
        riceAmtTxt.text = "Rice: " + riceAmt + "/" + maxRiceAmt;

        //animals
        chickenAmtTxt.text = "Chickens: " + chickenAmt + "/" + maxChickenAmt;
        eggsAmtTxt.text = "Eggs: " + eggsAmt + "/" + maxEggsAmt;

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
