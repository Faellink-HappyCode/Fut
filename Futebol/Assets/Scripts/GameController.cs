using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public int scoreRed, scoreBlue;
    public Text redScoreText, blueScoreText, turnText, whoWon;
    public GameObject panelGameOver;

    private GameObject MenuManager;

    public Sprite option1, option2, option3, option4;

    public GameObject blue1, blue2, blue3, blue4, blue5, blue6, blue7;
    public GameObject red1, red2, red3, red4, red5, red6, red7;

    public bool RedTurn;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreBlue = 0;
        scoreRed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTurn();
        UpdateScore();
        GameOver();
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene("game_scene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    void GameOver()
    {
        if (scoreRed == 3 || scoreBlue == 3)
        {
            Time.timeScale = 0;
            panelGameOver.SetActive(true);

            if (scoreRed == 3 && scoreRed > scoreBlue)
            {
                whoWon.color = Color.red;
                whoWon.text = "Red Wins!";
            }
            else if (scoreBlue == 3 && scoreRed < scoreBlue)
            {
                whoWon.color = Color.blue;
                whoWon.text = "Blue Wins!";
            }
        }
    }

    void UpdateTurn()
    {
        if (turnText!= null)
        {
            if (RedTurn)
            {
                turnText.color = Color.red;
                turnText.text = "Red Team's Turn";
            }
            else
            {
                turnText.color = Color.blue;
                turnText.text = "Blue Team's Turn";
            }
        }
    }
    
    void UpdateScore()
    {
        if (scoreRed != null)
        {
            redScoreText.text = scoreRed.ToString();
        }
        if (scoreBlue != null)
        {
            blueScoreText.text = scoreBlue.ToString();
        }
    }
}
