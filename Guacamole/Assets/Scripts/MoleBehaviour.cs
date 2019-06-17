using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
	public GameObject mole;
	public Transform spawnPoint;
	public Transform downPos, upPos;
	public float speed;
    public AudioClip WhackSound;
    private bool isAlive = true;

    Vector3 nextPos;

	// Start is called before the first frame updates
	void Start()
    {
        isAlive = false;

        nextPos = spawnPoint.position;

		Invoke("Spawn", Random.Range(10f, 3f));
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

		UpdateMovement();
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

	private void OnDrawGizmos()
	{
		Gizmos.DrawLine(downPos.position, upPos.position);
	}

}