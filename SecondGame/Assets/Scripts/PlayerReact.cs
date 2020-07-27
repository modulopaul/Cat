using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReact : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;

    void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name != "Player")
        {
            player.GetComponent<FollowFinger>().enabled = false;
            Time.timeScale = 0;
            menu.SetActive(true);
           
        }
    }
}
