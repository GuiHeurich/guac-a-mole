using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
	public GameObject mole;
	public Transform spawnPoint;
	public Transform downPos, upPos;
	public float speed = 2;
    public AudioClip WhackSound;
    private bool isAlive = true;
    private int level;

    Vector3 nextPos;

	// Start is called before the first frame updates
	void Start()
    {
        isAlive = false;

        nextPos = spawnPoint.position;

		Invoke("Spawn", Random.Range(3f, 0.3f));
	}

	// Update is called once per frame
	void Update()
	{
		UpdateMovement();
        UpdateDifficulty();
	}

	void OnMouseDown()
	{
		ScoreUpdate.scoreValue += 100;

        this.gameObject.GetComponent<AudioSource>().PlayOneShot(WhackSound);
        isAlive = false;

		// Function is executed after the delay
		Invoke("Spawn", Random.Range(3f, 0.3f));
	}

	public void Spawn()
	{
        isAlive = true;

        this.transform.position = spawnPoint.position;
	}

	public void UpdateMovement()
	{
        if (isAlive == false)
		{
			this.transform.position = spawnPoint.position;
		}
		else
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

	}

    public void UpdateDifficulty()
    {
        if (ScoreUpdate.scoreValue > 2000 && ScoreUpdate.scoreValue < 3000)
        {
            speed = 2.5f; 
        } else if (ScoreUpdate.scoreValue >= 3000 && ScoreUpdate.scoreValue < 4000)
        {
            speed = 3;
        } else if (ScoreUpdate.scoreValue >= 4000 && ScoreUpdate.scoreValue < 5000)
        {
            speed = 3.5f;
        } else if (ScoreUpdate.scoreValue >= 5000 && ScoreUpdate.scoreValue < 6000)
        {
            speed = 4;
        } else if (ScoreUpdate.scoreValue >= 6000 && ScoreUpdate.scoreValue < 7000)
        {
            speed = 4.5f;
        } else if (ScoreUpdate.scoreValue >= 7000 && ScoreUpdate.scoreValue < 8000)
        {
            speed = 5;
        } else if (ScoreUpdate.scoreValue >= 8000 && ScoreUpdate.scoreValue < 9000)
        {
            speed = 5.5f;
        } else if (ScoreUpdate.scoreValue >= 9000 && ScoreUpdate.scoreValue < 10000)
        {
            speed = 6;
        } else if (ScoreUpdate.scoreValue >= 10000 && ScoreUpdate.scoreValue < 11000)
        {
            speed = 6.5f;
        } else if (ScoreUpdate.scoreValue > 11000)
        {
            speed = ScoreUpdate.scoreValue / 1000 * 0.585f;
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawLine(downPos.position, upPos.position);
    }

}