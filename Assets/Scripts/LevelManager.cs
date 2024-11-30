using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int amountOfObjects;
    private InkScript inkScript;
    
    private GUIManager guiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        inkScript = GameObject.Find("NarrativeManager").GetComponent<InkScript>();
        amountOfObjects = 14;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void removeObject(GameObject item)
    {
        inkScript.playDialogue(item.gameObject.tag);
        Destroy(item);
        amountOfObjects--;
        if (amountOfObjects == 0)
        {
            endGame();
        }
    }

    private void endGame()
    {
        inkScript.ended = true;
    }
}
