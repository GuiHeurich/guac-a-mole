using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    public GameObject mole;
    public Transform spawnPoint;
    public Transform downPos, upPos;
    public float speed;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        mole.gameObject.SetActive(false);

        nextPos = spawnPoint.position;

        Invoke("Spawn", Random.Range(3f, 0.3f));
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    void OnMouseDown()
    {
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
            //...wait x seconds then come up
            nextPos = upPos.position;
        }
        if (transform.position == upPos.position)
        {
            //...wait x seconds then go down
            nextPos = downPos.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(downPos.position, upPos.position);
    }
}
