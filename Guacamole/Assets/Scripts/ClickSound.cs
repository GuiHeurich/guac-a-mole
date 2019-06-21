using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip ButtonSound;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickedSound()
    {
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(ButtonSound);
    }
}
