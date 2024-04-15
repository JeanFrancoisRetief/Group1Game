using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class request : MonoBehaviour
{
    [Header("Scripts")]
    public playerStats playerStats;

    [Header("Resources Requested")]
    public int wheatReq;
    public int cornReq;
    public int riceReq;
    //input values in the inspector

    [Header("Other Variables")]
    public int reqPending;
    public Text reqPendingTxt;

    public GameObject selectBtn;
    public GameObject sendBtn;

    private void Start()
    {
        selectBtn.SetActive(true);
        sendBtn.SetActive(false);
    }

    public void Send()
    {
        if (playerStats.wheatAmt >= wheatReq) //checks to see if the player has enough of the resource
        {
            playerStats.wheatAmt = playerStats.wheatAmt - 1; //subtracts once the resources are sent to requester
        }

        if (playerStats.cornAmt >= cornReq)
        {
            playerStats.cornAmt = playerStats.cornAmt - 1;
        }

        if (playerStats.riceAmt >= riceReq)
        {
            playerStats.riceAmt = playerStats.riceAmt - 1;
        }

        this.gameObject.SetActive(false); //deletes the game object as the request is now complete
    }

    public void Selected()
    {
        reqPending = reqPending + 1; //adds to requests that need to be fulfilled

        selectBtn.SetActive(false); //disables request selected button
        sendBtn.SetActive(true); //enables button that allows us to send in the resources and complete the request
    }
}
