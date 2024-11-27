using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.5f;
    private LevelManager levelManager;
    private GameObject item;
    
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        } 
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (item != null)
        {
            levelManager.removeObject(item);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CollectionObjects" && item == null)
        {
            item = collision.gameObject;
        }
    }
}
