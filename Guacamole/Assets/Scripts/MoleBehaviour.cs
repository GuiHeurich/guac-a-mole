using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    public GameObject mole;
    public Transform spawnPoint;
    public Transform downPos, upPos;
    public float speed;
    public new AudioSource audio;
    public bool play = false;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        mole.gameObject.SetActive(false);

        nextPos = spawnPoint.position;

        Invoke("Spawn", Random.Range(3f, 0.3f));
    }

    // Update is called once per frame
    void Update()
    {

        // Need to delay mole if at the bottom wait (i.e. stay there/ don't move) for x seconds
        // fun speed effect:
        //if (nextPos == upPos.position)
        //{
        //    Invoke("UpdateMovement", 3);
        //}
        if (play)
        {
            play = false;

            audio.PlayOneShot(audio.clip);
        }

        UpdateMovement();
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

    public void UpdateMovement()
    {
        if (transform.position == downPos.position)
        {
            nextPos = upPos.position;
        }
        if (transform.position == upPos.position)
        {
            nextPos = downPos.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(downPos.position, upPos.position);
    }
}
