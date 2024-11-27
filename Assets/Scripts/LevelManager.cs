using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int amountOfObjects;
    
    private GUIManager guiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        amountOfObjects = GameObject.FindGameObjectsWithTag("CollectionObjects").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (amountOfObjects == 0)
        {
            endGame();
        }
    }

    public void removeObject(GameObject item)
    {
        Destroy(item);
        amountOfObjects--;
        Debug.Log(amountOfObjects);
    }

    private void endGame()
    {
        
    }
}
