using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public GameObject mole;
    // Start is called before the first frame update
    void Start()
    {
        mole.gameObject.SetActive(true);
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
        Invoke("CreateMole", 0.8f);
    }

    void CreateMole()
    {
        mole.gameObject.SetActive(true);
    }
}
