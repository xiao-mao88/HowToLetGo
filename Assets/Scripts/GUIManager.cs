using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GUIManager : MonoBehaviour
{
    private LevelManager levelManager;
    private Label objectsLabel;
    private InkScript inkScript;
    
    private GroupBox objectsGroupBox;
    private Label dialogueLabel;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        inkScript = GameObject.Find("NarrativeManager").GetComponent<InkScript>();
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        objectsLabel = root.Q<Label>("objectsLeft");
        
        objectsGroupBox = root.Q<GroupBox>("narrative");
        dialogueLabel = root.Q<Label>("story");
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.amountOfObjects != 0)
        {
            objectsLabel.text = levelManager.amountOfObjects + " more to go...";
        }
        else if (levelManager.amountOfObjects == 0)
        {
            objectsLabel.text = "All objects found...";
        }

        if (inkScript.showDialogue)
        {
            dialogueLabel.text = inkScript.currentDialogue;
            objectsGroupBox.style.display = DisplayStyle.Flex;
        }
        else
        {
            objectsGroupBox.style.display = DisplayStyle.None;
        }
    }
}
