using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public GameObject mole;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(3f, 0.3f));
    }

    // Update is called once per frame
    void Update()
    {

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
}