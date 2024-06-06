using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

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

    public GameObject imgWheatReady;

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

    public GameObject imgCornReady;

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

    public GameObject imgRiceReady;

    [Header("Crop Plot")]
    public string cropPlotName;
    public Text cropPlotNameTxt;

    public float timeToGrow;
    public Text timerTxt;

    public int cost;

    public GameObject btnCrop1;
    public GameObject harvestBtn;
    public GameObject NotEnoughCoins;

    [Header("Unlock")]
    public bool isUnlocked;
    public GameObject btnPurchaseCrop;
    public Text txtCropPlotPrice;

    //other
    public GameObject pnlCrop1;
    public GameObject imgMaxCapacity;

    #endregion

    private void Start()
    {
        harvestBtn.SetActive(false);

        //crop plot
        cropPlotNameTxt.text = "Empty";

        //crop images
        imgWheatReady.SetActive(false);
        imgCornReady.SetActive(false);
        imgRiceReady.SetActive(false);

        //wheat
        wheatName = "Wheat";
        wheatNameTxt.text = wheatName;

        timeToGrowWheat = 30f;
        timeToGrowWheatTxt.text = timeToGrowWheat + "s";

        costWheat = 5;
        costWheatTxt.text = "Cost: " + costWheat;

        yieldWheat = 10;
        yieldWheatTxt.text = "Yield: " + yieldWheat + " " + wheatName;

        playerStats.maxWheatAmt = 25;

        //corn
        cornName = "Corn";
        cornNameTxt.text = cornName;

        timeToGrowCorn = 30f;
        timeToGrowCornTxt.text = timeToGrowCorn + "s";

        costCorn = 5;
        costCornTxt.text = "Cost: " + costCorn;

        yieldCorn = 10;
        yieldCornTxt.text = "Yield: " +  yieldCorn + " " + cornName;

        playerStats.maxCornAmt = 25;


        //rice
        riceName = "Rice";
        riceNameTxt.text = riceName;

        timeToGrowRice = 30f;
        timeToGrowRiceTxt.text = timeToGrowRice + "s";

        costRice = 5;
        costRiceTxt.text = "Cost: " + costRice;

        yieldRice = 10;
        yieldRiceTxt.text = "Yield: " + yieldRice + " " + riceName;

        playerStats.maxRiceAmt = 25;
    }

    private void Update()
    {
        //timer for crop
        if (timeToGrow > 0)
        {
            timeToGrow -= Time.deltaTime;
            btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = false;
        }
        else if (timeToGrow < 0)
        {
            timeToGrow = 0;

            if (wheatSelected)
            {
                imgWheatReady.SetActive(true);
            }

            if (cornSelected)
            {
                imgCornReady.SetActive(true);
            }

            if (riceSelected)
            {
                imgRiceReady.SetActive(true);
            }

            harvestBtn.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(timeToGrow / 60);
        int seconds = Mathf.FloorToInt(timeToGrow % 60);
        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //crop plot
        txtCropPlotPrice.text = "Buy: " + playerStats.cropPrice + " Coins";

        if (isUnlocked == true)
        {
            btnCrop1.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            btnPurchaseCrop.SetActive(false);
        }
        else
        {
            btnCrop1.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            btnPurchaseCrop.SetActive(true);
        }
    }

    public void buyCropPlot()
    {
        if (playerStats.coins >= playerStats.cropPrice)
        {
            playerStats.coins = playerStats.coins - playerStats.cropPrice;
            isUnlocked = true;

            playerStats.cropPrice = playerStats.cropPrice * 2;

            playerStats.xp = playerStats.xp + 25;
        }
        else
        {
            playerStats.notEnoughCoins.SetActive(true);
        }
    }

    public void growWheat()
    {
        if (playerStats.coins >= costWheat)
        {
            cropPlotName = wheatName;
            timeToGrow = timeToGrowWheat;
            cost = costWheat;

            playerStats.coins = playerStats.coins - cost;

            cropPlotNameTxt.text = cropPlotName;
            pnlCrop1.SetActive(false);
            btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = false;

            wheatSelected = true;
        }
        else
        {
            NotEnoughCoins.SetActive(true);
        }
    }

    public void growCorn()
    {
        if (playerStats.coins >= costCorn)
        {
            cropPlotName = cornName;
            timeToGrow = timeToGrowCorn;
            cost = costCorn;

            playerStats.coins = playerStats.coins - cost;

            cropPlotNameTxt.text = cropPlotName;
            pnlCrop1.SetActive(false);
            btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = false;

            cornSelected = true;
        }
        else
        {
            NotEnoughCoins.SetActive(true);
        }
    }

    public void growRice()
    {
        if (playerStats.coins >= costRice)
        {
            cropPlotName = riceName;
            timeToGrow = timeToGrowRice;
            cost = costRice;

            playerStats.coins = playerStats.coins - cost;

            cropPlotNameTxt.text = cropPlotName;
            pnlCrop1.SetActive(false);
            btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = false;

            riceSelected = true;
        }
        else
        {
            NotEnoughCoins.SetActive(true);
        }
    }

    public void Harvest()
    {
        if (playerStats.wheatAmt < playerStats.maxWheatAmt)
        {
            if (wheatSelected == true)
            {
                playerStats.wheatAmt = playerStats.wheatAmt + yieldWheat;
                wheatSelected = false;
                harvestBtn.SetActive(false);
                imgWheatReady.SetActive(false);

                if (playerStats.wheatAmt >= playerStats.maxWheatAmt)
                {
                    playerStats.wheatAmt = playerStats.maxWheatAmt;
                }

                playerStats.xp = playerStats.xp + 5;

                cropPlotNameTxt.text = "Empty";
                btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = true;
            }
        }
        else
        {
            imgMaxCapacity.SetActive(true);
        }

        if (playerStats.cornAmt < playerStats.maxCornAmt)
        {
            if (cornSelected == true)
            {
                playerStats.cornAmt = playerStats.cornAmt + yieldCorn;
                cornSelected = false;
                harvestBtn.SetActive(false);
                imgCornReady.SetActive(false);

                if (playerStats.cornAmt >= playerStats.maxCowAmt)
                {
                    playerStats.cornAmt = playerStats.maxCornAmt;
                }

                playerStats.xp = playerStats.xp + 5;

                cropPlotNameTxt.text = "Empty";
                btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = true;
            }
        }
        else
        {
            imgMaxCapacity.SetActive(true);
        }

        if (playerStats.riceAmt < playerStats.maxRiceAmt)
        {

            if (riceSelected == true)
            {
                playerStats.riceAmt = playerStats.riceAmt + yieldRice;
                riceSelected = false;
                harvestBtn.SetActive(false);
                imgRiceReady.SetActive(false);

                if (playerStats.riceAmt >= playerStats.maxRiceAmt)
                {
                    playerStats.riceAmt = playerStats.maxRiceAmt;
                }

                playerStats.xp = playerStats.xp + 5;

                cropPlotNameTxt.text = "Empty";
                btnCrop1.GetComponent<UnityEngine.UI.Button>().enabled = true;
            }
        }
        else
        {
            imgMaxCapacity.SetActive(true);
        }
    }
}
