using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager instance;

    public TextMeshProUGUI textComponent;

    private void Awake()
    {
       if(instance != null && instance != this)
       {
            Destroy(this.gameObject); 
       }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowToolTip(string message)
    {
        gameObject.SetActive(true);
        textComponent.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}
