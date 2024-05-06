using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class InteractTriggerScript : MonoBehaviour
{
    public Text TextHint;

    public GameObject InteractionPanel;
    public Text InteractionText;

    //public int dialogueCount = 0;
    public bool inInteract = false;
    public string InteractString;

    //public Global global;

    // Start is called before the first frame update
    void Start()
    {
        //global.InteractCounter = 0;
        inInteract = false;
        InteractionPanel.SetActive(false);
        InteractionText.text = "";
        //InteractString = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TextHint.text = "Press E to Interact";
        inInteract = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (inInteract == false))
        {
            TextHint.text = "";
            EnterInteract();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        TextHint.text = "";
        InteractionPanel.SetActive(false);
        InteractionText.text = "";

        if (inInteract == true)
        {
            gameObject.SetActive(false);
        }
    }

    void EnterInteract()
    {
        inInteract = true;
        //global.InteractCounter++;
        InteractionPanel.SetActive(true);

        InteractionText.text = InteractString;//change is inspector!!!

        /*if (global.InteractCounter == 1)
        {
            InteractionText.text = "Posters on my Wall, I love the animations!"; wait this wont work
        }
        else if (global.InteractCounter == 2)
        {
            InteractionText.text = "Hey, can't come out now. This new game is SOOOO addictive!";
        }
        else if (global.InteractCounter == 3)
        {
            InteractionText.text = "(I can hear mouse clicks from the room - They must be ignoring me.)";
        }
        else
        {
            InteractionText.text = "";
        }*/
    }
}
