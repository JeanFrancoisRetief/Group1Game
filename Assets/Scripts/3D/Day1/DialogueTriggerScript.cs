using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class DialogueTriggerScript : MonoBehaviour
{
    public Text TextHint;

    public GameObject DialoguePanel;
    public Text DialogueText;

    //public int neighbourNo;

    //public int dialogueCount = 0;
    public bool inDialogue = false;
    public string Dialogue01;
    public string Dialogue02;
    public string Dialogue03;

    public Global global;
    public audioDialogue audioDialogue;

    // Start is called before the first frame update
    void Start()
    {
        global.DialogueCounter = 0;
        inDialogue = false;
        DialoguePanel.SetActive(false);
        DialogueText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        TextHint.text = "Press E to Talk to neighbor";
        inDialogue = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (inDialogue == false))
        {
            TextHint.text = "";
            EnterDialogue();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        TextHint.text = "";
        DialoguePanel.SetActive(false);

        if (inDialogue == true)
        {
            gameObject.SetActive(false);
        }
    }

    void EnterDialogue()
    {
        inDialogue = true;
        global.DialogueCounter++;
        DialoguePanel.SetActive(true);
        if(global.DialogueCounter == 1)
        {
            if (global.DayCounter == 1)
            {
                audioDialogue.ASneighbour1.clip = audioDialogue.neighbour1Clip1;
                audioDialogue.ASneighbour1.Play();
            }

            if (global.DayCounter == 2)
            {
                audioDialogue.ASneighbour1.clip = audioDialogue.neighbour1Clip2;
                audioDialogue.ASneighbour1.Play();
            }

            if (global.DayCounter == 3)
            {
                audioDialogue.ASneighbour1.clip = audioDialogue.neighbour1Clip3;
                audioDialogue.ASneighbour1.Play();
            }

            DialogueText.text = Dialogue01;
            //"I'm a bit busy. Playing a new game I got today!!! Talk to you tommorow though?";
        }
        else if (global.DialogueCounter == 2)
        {
            if (global.DayCounter == 1)
            {
                audioDialogue.ASneighbour2.clip = audioDialogue.neighbour2Clip1;
                audioDialogue.ASneighbour2.Play();
            }

            if (global.DayCounter == 2)
            {
                audioDialogue.ASneighbour2.clip = audioDialogue.neighbour2Clip2;
                audioDialogue.ASneighbour2.Play();
            }

            DialogueText.text = Dialogue02;
            // "Hey, can't come out now. This new game is SOOOO addictive!";
        }
        else if (global.DialogueCounter == 3)
        {
            if (global.DayCounter == 1)
            {
                audioDialogue.ASneighbour3.clip = audioDialogue.neighbour3Clip1;
                audioDialogue.ASneighbour3.Play();
            }

            if (global.DayCounter == 2)
            {
                audioDialogue.ASneighbour3.clip = audioDialogue.neighbour3Clip2;
                audioDialogue.ASneighbour3.Play();
            }

            if (global.DayCounter == 3)
            {
                audioDialogue.ASneighbour3.clip = audioDialogue.neighbour3Clip3;
                audioDialogue.ASneighbour3.Play();
            }

            DialogueText.text = Dialogue03;
            // "(I can hear mouse clicks from the room - They must be ignoring me.)";
        }
        else
        {
            DialogueText.text = "";
        }
    }

}
