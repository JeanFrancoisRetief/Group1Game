using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMessage : MonoBehaviour
{
    public Text StartText;
    public Color zm;  //  makes a new color zm
    public string startMessage;

    // Start is called before the first frame update
    void Start()
    {
        //StartText.text = "Monday 10:23 AM";
        StartText.text = startMessage;
        zm = StartText.color;
        zm.a = 255f;
        
        StartText.color = zm;
    }

    // Update is called once per frame
    void Update()
    {
        zm.a--;
  

        StartText.color = zm;
    }
}
