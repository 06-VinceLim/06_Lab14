using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedSphere : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject RedText;
    public int Red;
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
            Red++;

            audioSource.Play();

            RedText.GetComponent<Text>().text = "Red : " + Red;


        }
    }
}
