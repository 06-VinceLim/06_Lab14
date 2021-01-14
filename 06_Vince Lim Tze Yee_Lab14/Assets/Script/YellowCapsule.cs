using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowCapsule : MonoBehaviour
{
    public GameObject YellowText;
    public int Yellow;
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
            Yellow++;

            YellowText.GetComponent<Text>().text = "Yellow : " + Yellow;

            audioSource.Play();
        }

    }
}
