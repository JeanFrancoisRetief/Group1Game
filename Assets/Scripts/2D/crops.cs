using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crops : MonoBehaviour
{
    #region variables

    [Header("Scripts")]
    public playerStats playerStats;

    [Header("Wheat")]
    public string wheatName;
    public Text wheatNameTxt;

    public float timeToGrowWheat;
    public Text timeToGrowWheatTxt;

    public int costWheat;
    public Text costWheatTxt;

    public int yieldWheat;
    public Text yieldWheatTxt;

    public bool wheatSelected;

    [Header("Corn")]
    public string cornName;
    public Text cornNameTxt;

    public float timeToGrowCorn;
    public Text timeToGrowCornTxt;

    public int costCorn;
    public Text costCornTxt;

    public int yieldCorn;
    public Text yieldCornTxt;

    public bool cornSelected;

    [Header("Rice")]
    public string riceName;
    public Text riceNameTxt;

    public float timeToGrowRice;
    public Text timeToGrowRiceTxt;

    public int costRice;
    public Text costRiceTxt;

    public int yieldRice;
    public Text yieldRiceTxt;

    public bool riceSelected;

    [Header("Crop Plot")]
    public string cropPlotName;
    public Text cropPlotNameTxt;

    public float timeToGrow;
    public Text timerTxt;

    public int cost;

    public GameObject harvestBtn;

    #endregion

    private void Start()
    {
        harvestBtn.SetActive(false);

        //wheat
        wheatName = "Wheat";
        wheatNameTxt.text = wheatName;

        timeToGrowWheat = 30f;
        timeToGrowWheatTxt.text = timeToGrowWheat + "s";

        costWheat = 5;
        costWheatTxt.text = "Cost: " + costWheat;

        yieldWheat = 10;
        yieldWheatTxt.text = "Yield: " + wheatName;

        //corn
        cornName = "Corn";
        cornNameTxt.text = cornName;

        timeToGrowCorn = 30f;
        timeToGrowCornTxt.text = timeToGrowCorn + "s";

        costCorn = 5;
        costCornTxt.text = "Cost: " + costCorn;

        yieldCorn = 10;
        timeToGrowCornTxt.text = timeToGrowCorn + cornName;

        //rice
        riceName = "Rice";
        riceNameTxt.text = riceName;

        timeToGrowRice = 30f;
        timeToGrowRiceTxt.text = timeToGrowRice + "s";

        costRice = 5;
        costRiceTxt.text = "Cost: " + costRice;

        yieldRice = 10;
        yieldRiceTxt.text = "Yield: " + riceName;
    }

    private void Update()
    {
        //timer for crop
        if (timeToGrow > 0)
        {
            timeToGrow -= Time.deltaTime;
        }
        else if (timeToGrow < 0)
        {
            timeToGrow = 0;

            harvestBtn.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(timeToGrow / 60);
        int seconds = Mathf.FloorToInt(timeToGrow % 60);
        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void growWheat()
    {
        cropPlotName = wheatName;
        timeToGrow = timeToGrowWheat;
        cost = costWheat;

        playerStats.coins = playerStats.coins - cost;

        cropPlotNameTxt.text = cropPlotName;

        wheatSelected = true;
    }

    public void growCorn()
    {
        cropPlotName = cornName;
        timeToGrow = timeToGrowCorn;
        cost = costCorn;

        playerStats.coins = playerStats.coins - cost;

        cropPlotNameTxt.text = cropPlotName;

        cornSelected = true;
    }

    public void growRice()
    {
        cropPlotName = riceName;
        timeToGrow = timeToGrowRice;
        cost = costRice;

        playerStats.coins = playerStats.coins - cost;

        cropPlotNameTxt.text = cropPlotName;

        riceSelected = true;
    }

    public void Harvest()
    {
        if (wheatSelected ==  true)
        {
            yieldWheat = playerStats.wheatAmt + yieldWheat;
            wheatSelected = false;
        }

        if (cornSelected == true)
        {
            yieldCorn = playerStats.cornAmt + yieldCorn;
            cornSelected = false;
        }

        if (riceSelected == true)
        {
            yieldRice = playerStats.riceAmt + yieldRice;
            riceSelected = false;
        }
    }
}
