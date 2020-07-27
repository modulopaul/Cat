using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathImageAppear : MonoBehaviour
{
    public GameObject menu;
    public GameObject score;

    void Start()
    {
        menu.SetActive(false);
    }
    void Update()
    {
        if (Time.timeScale == 0)
        {
            menu.SetActive(true);
            score.SetActive(false);
        }
    }
}
