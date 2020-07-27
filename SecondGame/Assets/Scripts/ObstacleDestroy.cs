using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ObstacleDestroy : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextfinal;
    static public int score;
    static public int highscore;
    static bool ok = true;

    void Start()
    {
        //OnApplicationQuit();
        
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (ok == true)
            {
                highscore = PlayerPrefs.GetInt("HighScore");
                score = PlayerPrefs.GetInt("LatestScore");
            }
            if (score > highscore)
            {
                highscore = score;                
            }
            if (highscore > 1000000000)
                highscore = 1000000000;
            if (score > 1000000000)
                score = 1000000000;
            scoreText.text=score.ToString();
            scoreTextfinal.text = highscore.ToString();
        }
        else if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            score = 0;
            ok = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        score++;
        scoreText.text = score.ToString();
        scoreTextfinal.text = score.ToString();
                    
    }
    void OnApplicationQuit()
    {  
        PlayerPrefs.SetInt("HighScore", highscore);
        PlayerPrefs.SetInt("LatestScore", score);
    }

}
