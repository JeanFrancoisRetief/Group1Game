using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    //player stats
    public int lvl;
    public Text lvlTxt;
    public int xp;
    public int xpLimit;
    public Slider sldXP;
    public int coins;
    public Text coinsTxt;

    //crop stats
    public int wheatAmt;
    public int cornAmt;
    public int riceAmt;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 0;
        xp = 0;
        xpLimit = 10;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
