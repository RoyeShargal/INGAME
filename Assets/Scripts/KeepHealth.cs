using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepHealth : MonoBehaviour
{
    public static int health;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "HP: " + health;
    }
}
