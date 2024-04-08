using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    public int lvl;
    public Text lvlTxt;
    public int xp;
    public int xpLimit;
    public Slider sldXP;
    public int coins;
    public Text coinsTxt;

    public int reqPending;
    public Text reqPendingTxt;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 0;
        xp = 0;
        xpLimit = 10;
        coins = 0;
        reqPending = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sldXP.value = xp;
        lvlTxt.text = "Lvl: " + lvl;

        coinsTxt.text = "Coins: " + coins;

        if (xp >= xpLimit)
        {
            xp = 0;

            xpLimit = xpLimit * 2;

            lvl = lvl + 1;
        }
    }

    public void Selected()
    {
        reqPending = reqPending + 1;
    }
}
