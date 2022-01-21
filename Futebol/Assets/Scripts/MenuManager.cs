using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public int p1ChoiceNum,p2ChoiceNum;
    public Image imgP1,imgP2;

    public Sprite option0,option00,option1,option2,option3,option4;

    bool haveChoosen;


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        p1ChoiceNum = 0;
        p2ChoiceNum = 0;
        haveChoosen = false;
    }

    public void P1Plus()
    {
        p1ChoiceNum++;

        if (p1ChoiceNum > 4)
        {
            p1ChoiceNum = 0;
        }
    }

    public void P1Less()
    {
        p1ChoiceNum--;

        if (p1ChoiceNum < 0)
        {
            p1ChoiceNum = 4;
        }
    }

    public void P2Plus()
    {
        p2ChoiceNum++;

        if (p2ChoiceNum > 4)
        {
            p2ChoiceNum = 0;
        }
    }

    public void P2Less()
    {
        p2ChoiceNum--;

        if (p2ChoiceNum < 0)
        {
            p2ChoiceNum = 4;
        }
    }
        
    ///////////////////////////////////////////////////////////////////////////////

    public void PlayButton()//use it in play button
    {
        Choose();
        SceneManager.LoadScene("game_scene");
    }

    void SetP1PreviewChoice()
    {
        if(!haveChoosen && imgP1 != null)
        {
            if(p1ChoiceNum == 0)
            {
                imgP1.GetComponent<Image>().sprite = option0;
            }
            else if(p1ChoiceNum == 1)
            {
                imgP1.GetComponent<Image>().sprite = option1;
            }

            else if(p1ChoiceNum == 2)
            {
                imgP1.GetComponent<Image>().sprite = option2;
            }

            else if(p1ChoiceNum == 3)
            {
                imgP1.GetComponent<Image>().sprite= option3;
            }

            else if(p1ChoiceNum == 4)
            {
                imgP1.GetComponent<Image>().sprite= option4;
            }
        }
    }

    void SetP2PreviewChoice()
    {
        if(!haveChoosen && imgP2 != null)
        {
            if(p2ChoiceNum == 0)
            {
                imgP2.GetComponent<Image>().sprite = option00;
            }
            else if(p2ChoiceNum == 1)
            {
                imgP2.GetComponent<Image>().sprite = option1;
            }

            else if(p2ChoiceNum == 2)
            {
                imgP2.GetComponent<Image>().sprite = option2;
            }

            else if(p2ChoiceNum == 3)
            {
                imgP2.GetComponent<Image>().sprite = option3;
            }

            else if(p2ChoiceNum == 4)
            {
                imgP2.GetComponent<Image>().sprite = option4;
            }
        }
    }

    void Update()
    {
        SetP1PreviewChoice();
        SetP2PreviewChoice();
    }

    public void Choose()
    {
        haveChoosen = true;
    }
}
