using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int amountOfObjects;
    private InkScript inkScript;
    
    private GUIManager guiManager;
    
    private AudioSource audioSource;
    
    [SerializeField] private AudioClip clip_Collect;
    [SerializeField] private AudioClip clip_AllCollect;
    [SerializeField] private AudioClip clip_Revive;
    
    // Start is called before the first frame update
    void Start()
    {
        inkScript = GameObject.Find("NarrativeManager").GetComponent<InkScript>();
        amountOfObjects = 14;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void removeObject(GameObject item)
    {
        audioSource.PlayOneShot(clip_Collect);
        inkScript.playDialogue(item.gameObject.tag);
        Destroy(item);
        amountOfObjects--;
        if (amountOfObjects == 0)
        {
            audioSource.PlayOneShot(clip_AllCollect);
            endGame();
        }
    }

    private void endGame()
    {
        inkScript.ended = true;
    }
}
