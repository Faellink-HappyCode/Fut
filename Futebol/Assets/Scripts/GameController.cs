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
        Time.timeScale = 1;
        scoreBlue = 0;
        scoreRed = 0;
        RedTurn = false;
        panelGameOver.SetActive(false);
        MenuManager = GameObject.Find("Menu Manager");
        SetPlayer1Skins();
        SetPlayer2Skins();
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
    
    void SetPlayer1Skins()
    {
        switch (MenuManager.GetComponent<MenuManager>().p1ChoiceNum)
        {
            case 1:
                blue1.GetComponent<SpriteRenderer>().sprite = option1;
                blue2.GetComponent<SpriteRenderer>().sprite = option1;
                blue3.GetComponent<SpriteRenderer>().sprite = option1;
                blue4.GetComponent<SpriteRenderer>().sprite = option1;
                blue5.GetComponent<SpriteRenderer>().sprite = option1;
                blue6.GetComponent<SpriteRenderer>().sprite = option1;
                blue7.GetComponent<SpriteRenderer>().sprite = option1;
                break;
            case 2:
                blue1.GetComponent<SpriteRenderer>().sprite = option2;
                blue2.GetComponent<SpriteRenderer>().sprite = option2;
                blue3.GetComponent<SpriteRenderer>().sprite = option2;
                blue4.GetComponent<SpriteRenderer>().sprite = option2;
                blue5.GetComponent<SpriteRenderer>().sprite = option2;
                blue6.GetComponent<SpriteRenderer>().sprite = option2;
                blue7.GetComponent<SpriteRenderer>().sprite = option2;
                break;
            case 3:
                blue1.GetComponent<SpriteRenderer>().sprite = option3;
                blue2.GetComponent<SpriteRenderer>().sprite = option3;
                blue3.GetComponent<SpriteRenderer>().sprite = option3;
                blue4.GetComponent<SpriteRenderer>().sprite = option3;
                blue5.GetComponent<SpriteRenderer>().sprite = option3;
                blue6.GetComponent<SpriteRenderer>().sprite = option3;
                blue7.GetComponent<SpriteRenderer>().sprite = option3;
                break;
            case 4:
                blue1.GetComponent<SpriteRenderer>().sprite = option4;
                blue2.GetComponent<SpriteRenderer>().sprite = option4;
                blue3.GetComponent<SpriteRenderer>().sprite = option4;
                blue4.GetComponent<SpriteRenderer>().sprite = option4;
                blue5.GetComponent<SpriteRenderer>().sprite = option4;
                blue6.GetComponent<SpriteRenderer>().sprite = option4;
                blue7.GetComponent<SpriteRenderer>().sprite = option4;
                break;
        }
    }
    
    void SetPlayer2Skins()
    {
        switch (MenuManager.GetComponent<MenuManager>().p2ChoiceNum)
        {
            case 1:
                red1.GetComponent<SpriteRenderer>().sprite = option1;
                red2.GetComponent<SpriteRenderer>().sprite = option1;
                red2.GetComponent<SpriteRenderer>().sprite = option1;
                red4.GetComponent<SpriteRenderer>().sprite = option1;
                red5.GetComponent<SpriteRenderer>().sprite = option1;
                red6.GetComponent<SpriteRenderer>().sprite = option1;
                red7.GetComponent<SpriteRenderer>().sprite = option1;
                break;
            case 2:
                red1.GetComponent<SpriteRenderer>().sprite = option2;
                red2.GetComponent<SpriteRenderer>().sprite = option2;
                red2.GetComponent<SpriteRenderer>().sprite = option2;
                red4.GetComponent<SpriteRenderer>().sprite = option2;
                red5.GetComponent<SpriteRenderer>().sprite = option2;
                red6.GetComponent<SpriteRenderer>().sprite = option2;
                red7.GetComponent<SpriteRenderer>().sprite = option2;
                break;
            case 3:
                red1.GetComponent<SpriteRenderer>().sprite = option3;
                red2.GetComponent<SpriteRenderer>().sprite = option3;
                red2.GetComponent<SpriteRenderer>().sprite = option3;
                red4.GetComponent<SpriteRenderer>().sprite = option3;
                red5.GetComponent<SpriteRenderer>().sprite = option3;
                red6.GetComponent<SpriteRenderer>().sprite = option3;
                red7.GetComponent<SpriteRenderer>().sprite = option3;
                break;
            case 4:
                red1.GetComponent<SpriteRenderer>().sprite = option4;
                red2.GetComponent<SpriteRenderer>().sprite = option4;
                red2.GetComponent<SpriteRenderer>().sprite = option4;
                red4.GetComponent<SpriteRenderer>().sprite = option4;
                red5.GetComponent<SpriteRenderer>().sprite = option4;
                red6.GetComponent<SpriteRenderer>().sprite = option4;
                red7.GetComponent<SpriteRenderer>().sprite = option4;
                break;
        }
    }

}
