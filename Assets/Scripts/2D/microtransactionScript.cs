using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microtransactionScript : MonoBehaviour
{
    public int gems;
    public int coins;

    public GameObject img_NoMoreGems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GemsForCoinsOnClick()
    {
        if (gems > 0)
        {
            gems--;
            coins += 500;
        }
        else
        {
            img_NoMoreGems.SetActive(true);
        }
    }
}
