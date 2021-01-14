using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeCapsule : MonoBehaviour
{
    public GameObject OrangeText;
    public int Orange;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Orange++;

            OrangeText.GetComponent<Text>().text = "Orange : " + Orange;

            audioSource.Play();
        }
    }
    }
