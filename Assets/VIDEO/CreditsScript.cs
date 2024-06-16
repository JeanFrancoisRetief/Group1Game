using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public GameObject CreditsText;

    public int framecount;

    [SerializeField]
    public int seconds;

    void Start()
    {
        framecount = 0;
        seconds = 0;
        
    }
    private void Update()
    {

        CreditsText.transform.Translate(Vector3.up);

        framecount++;
        if (framecount >= 60)
        {
            seconds++;
            framecount = 0;
        }

        if(seconds >= 60)
        {
            //Debug.Log("Exit Program");
            SceneManager.LoadScene("Main Menu");
        }

    }


}
