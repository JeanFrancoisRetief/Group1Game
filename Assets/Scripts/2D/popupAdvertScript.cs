using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupAdvertScript : MonoBehaviour
{
    //[SerializeField]
    public GameObject AdvertPanel;
    public GameObject FarmPanel;

    public GameObject Ad001;
    public GameObject Ad002;
    public GameObject Ad003;
    public GameObject Ad004;
    public GameObject Ad005;
    public GameObject Ad006;

    public int AdvertNumber;
    public int frameCounter;
    public int seconds;
    public int randomTimeSeconds;
    // Start is called before the first frame update
    void Start()
    {
        frameCounter = 0;
        AdvertNumber = 1;
        seconds = 0;
        randomTimeSeconds = Random.Range(10, 41);
    }

    // Update is called once per frame
    void Update()
    {
        if(FarmPanel.active)
        {
            frameCounter++;
            if (frameCounter >= 60)
            {
                seconds++;
                frameCounter = 0;
            }

            if (seconds >= randomTimeSeconds)
            {
                PopupAdvert();
                seconds = 0;
                randomTimeSeconds = Random.Range(10, 31);
            }
        }

        

    }

    public void PopupAdvert()
    {
        AdvertPanel.SetActive(true);

        if (AdvertNumber == 1)
        {
            Ad001.SetActive(true);
            Ad002.SetActive(false);
            Ad003.SetActive(false);
            Ad004.SetActive(false);
            Ad005.SetActive(false);
            Ad006.SetActive(false);
            AdvertNumber = 2;
        }

        else if (AdvertNumber == 2)
        {
            Ad001.SetActive(false);
            Ad002.SetActive(true);
            Ad003.SetActive(false);
            Ad004.SetActive(false);
            Ad005.SetActive(false);
            Ad006.SetActive(false);
            AdvertNumber = 3;
        }

        else if (AdvertNumber == 3)
        {
            Ad001.SetActive(false);
            Ad002.SetActive(false);
            Ad003.SetActive(true);
            Ad004.SetActive(false);
            Ad005.SetActive(false);
            Ad006.SetActive(false);
            AdvertNumber = 4;
        }

        else if (AdvertNumber == 4)
        {
            Ad001.SetActive(false);
            Ad002.SetActive(false);
            Ad003.SetActive(false);
            Ad004.SetActive(true);
            Ad005.SetActive(false);
            Ad006.SetActive(false);
            AdvertNumber = 5;
        }

        else if (AdvertNumber == 5)
        {
            Ad001.SetActive(false);
            Ad002.SetActive(false);
            Ad003.SetActive(false);
            Ad004.SetActive(false);
            Ad005.SetActive(true);
            Ad006.SetActive(false);
            AdvertNumber = 6;
        }

        else if (AdvertNumber == 6)
        {
            Ad001.SetActive(false);
            Ad002.SetActive(false);
            Ad003.SetActive(false);
            Ad004.SetActive(false);
            Ad005.SetActive(false);
            Ad006.SetActive(true);
            AdvertNumber = 1;
        }
    }
}
