using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurpleSphere : MonoBehaviour
{
    public GameObject PurpleText;
    public int Purple;
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
            Purple++;

            PurpleText.GetComponent<Text>().text = "Purple : " + Purple;

            audioSource.Play();
        }
    }
}
