using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GUIManager : MonoBehaviour
{
    private LevelManager levelManager;
    private Label objectsLabel;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        objectsLabel = root.Q<Label>("objectsLeft");
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.amountOfObjects != 0)
        {
            objectsLabel.text = levelManager.amountOfObjects + " more to go...";
        }
    }
}
