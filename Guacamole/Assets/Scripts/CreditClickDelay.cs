using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditClickDelay : MonoBehaviour
{
    public GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        shield.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DisableShield", 0.5f);
    }

    public void DisableShield()
    {
        shield.gameObject.SetActive(false);
    }
}
