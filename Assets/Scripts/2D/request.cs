using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class request : MonoBehaviour
{
    [Header("Scripts")]
    public playerStats playerStats;

    [Header("Request Information")]
    public string requestor;
    public Text txtRequestor;
    public string requestedItems;
    public Text txtRequestedItems;
    public bool glitchReq;

    [Header("Resources Requested")]
    public int wheatReq;
    public int cornReq;
    public int riceReq;
    public int chickensReq;
    public int eggsReq;
    public int cowsReq;
    public int milkReq;

    [Header("Earned")]
    public int pay;
    public int xpEarned;

    [Header("Other")]
    public GameObject selectBtn;
    public GameObject sendBtn;
    public GameObject unable;


    private void Start()
    {
        selectBtn.SetActive(true);
        sendBtn.SetActive(false);

        this.gameObject.SetActive(true);
    }

    private void Update()
    {
        txtRequestor.text = requestor;

        txtRequestedItems.text = requestedItems;

        if (glitchReq == false)
        {
            requestedItems = wheatReq + " Wheat; "
                + cornReq + " Corn; "
                + riceReq + " Rice; "
                + chickensReq + " Chickens; "
                + eggsReq + " Eggs; "
                + cowsReq + " Cows; "
                + milkReq + " Milk Bottles";
        }
        else
        {
            txtRequestedItems.text = "Get the #*$& out!";
        }
    }

    public void Send()
    {
        if (playerStats.wheatAmt >= wheatReq && playerStats.cornAmt >= cornReq && playerStats.riceAmt >= riceReq && playerStats.chickenAmt >= chickensReq && playerStats.eggsAmt >= eggsReq && playerStats.cowAmt >= cowsReq && playerStats.milkBottlesAmt >= milkReq) //checks to see if the player has enough of the resource
        {
            playerStats.coins = playerStats.coins + pay + (pay * (playerStats.transportBenefit * 100)); //adds the money earned from request to the total coins
            playerStats.reqPending = playerStats.reqPending - 1; //removes one request because it was completed
            playerStats.xp = playerStats.xp + xpEarned;

            playerStats.wheatAmt = playerStats.wheatAmt - wheatReq; //subtracts once the resources are sent to requester
            playerStats.cornAmt = playerStats.cornAmt - cornReq;
            playerStats.riceAmt = playerStats.riceAmt - riceReq;
            playerStats.chickenAmt = playerStats.chickenAmt - chickensReq;
            playerStats.eggsAmt = playerStats.eggsAmt - eggsReq;
            playerStats.cowAmt = playerStats.cowAmt - cowsReq;
            playerStats.milkBottlesAmt = playerStats.milkBottlesAmt - milkReq;

            this.gameObject.SetActive(false); //deletes the game object as the request is now complete
        }
        else
        {
            unable.SetActive(true);
        }
    }

    public void Selected()
    {
        playerStats.reqPending = playerStats.reqPending + 1; //adds to requests that need to be fulfilled

        selectBtn.SetActive(false); //disables request selected button
        sendBtn.SetActive(true); //enables button that allows us to send in the resources and complete the request
    }
}
