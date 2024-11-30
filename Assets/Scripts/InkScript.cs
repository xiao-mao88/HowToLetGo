using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;
using Unity.VisualScripting;
using UnityEngine;

public class InkScript : MonoBehaviour
{
    public TextAsset inkJson;
    private Story story;
    public bool showDialogue;
    public String currentDialogue;

    public bool ended = false;
    // Start is called before the first frame update
    void Start()
    { 
        story = new Story(inkJson.text);
        showDialogue = true;
        currentDialogue = story.Continue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (story.canContinue)
            {
                showDialogue = true;
                currentDialogue = story.Continue();
            }
            else
            {
                showDialogue = false;
            }
            if (ended)
            {
                if (story.currentChoices.Count > 0)
                {
                    story.ChooseChoiceIndex(14);
                    currentDialogue = story.Continue();
                    showDialogue = true;
                }
            }
        }
    }

    public void playDialogue(string tag)
    {
        switch (tag)
        {
            case "flower":
                story.ChooseChoiceIndex(0);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "wedding":
                story.ChooseChoiceIndex(2);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "notebook":
                story.ChooseChoiceIndex(3);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "mainCharacterPic":
                story.ChooseChoiceIndex(12);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "phone":
                story.ChooseChoiceIndex(6);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "briefcase":
                story.ChooseChoiceIndex(10);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "brokenMirror":
                story.ChooseChoiceIndex(8);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "watch":
                story.ChooseChoiceIndex(4);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "doll":
                story.ChooseChoiceIndex(13);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "letter":
                story.ChooseChoiceIndex(9);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "ring":
                story.ChooseChoiceIndex(7);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "map":
                story.ChooseChoiceIndex(1);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "art":
                story.ChooseChoiceIndex(11);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
            case "music":
                story.ChooseChoiceIndex(5);
                currentDialogue = story.Continue();
                showDialogue = true;
                break;
        }
    }
}
