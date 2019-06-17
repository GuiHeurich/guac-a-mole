using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public new AudioSource audio;
    public bool play = false;
    public GameObject mole;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        Invoke("Spawn", Random.Range(3f, 0.3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            play = false;

            audio.PlayOneShot(audio.clip);
        }

    }

    void OnMouseDown()
    {
        play = true;
        ScoreUpdate.scoreValue += 100;
        mole.gameObject.SetActive(false);

        // Function is executed after the delay
        Invoke("Spawn", Random.Range(3f, 0.3f));
    }


    public void Spawn()
    {
        mole.gameObject.SetActive(true);
        this.transform.position = spawnPoint.position;
    }
}