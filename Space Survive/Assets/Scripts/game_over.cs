using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class game_over : MonoBehaviour
{

    public TMP_Text scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score : " + score.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            restartGame();
        }
    }

    public void restartGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
