using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Parsed;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
public class Player : MonoBehaviour
{
    public float speed = 1.5f;
    private LevelManager levelManager;
    private GameObject item;
    [SerializeField] 
    [Tooltip("Insert Animator Controller")]
    private Animator playerAnimator;
    [SerializeField] private AudioClip[] walkSounds;
    private AudioSource playerAS1;
    private List<string> tags = 
        new List<string> {"flower", "wedding", "notebook", "mainCharacterPic", "phone", "briefcase", "brokenMirror",
            "watch", "doll", "letter", "ring", "map", "art", "music"};
    
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        playerAS1 = GetComponent<AudioSource>();
        playerAnimator.SetBool("isWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) {
            transform.position += Vector3.left * speed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (item != null)
        {
            levelManager.removeObject(item);
        }
    }

    public void footStep()
    {
        playerAS1.clip = walkSounds[Random.Range(0, walkSounds.Length)];
        playerAS1.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tags.Contains(tag) && item == null)
        {
            item = collision.gameObject;
        }
    }
}
