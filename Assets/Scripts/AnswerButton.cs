using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private int AnswerNum;
    [SerializeField] private GameObject QuestionUI;
    [SerializeField] private GameObject GreatAnswerUI;
    [SerializeField] private GameObject GoodAnswerUI;
    [SerializeField] private GameObject BadAnswerUI;
    [SerializeField] private GameObject ButtonUI;
    public TextMeshProUGUI greatAnswerResponse;
    public TextMeshProUGUI goodAnswerResponse;
    public TextMeshProUGUI badAnswerResponse;

    public GameObject animationGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AnswerQuestion(int Button)
    {
        if (Button == 1)
        {
            Debug.Log("Button 1");
            if (GameManager.instance.currentQuestion.answer1movement == 2)
            {
                Debug.Log("Great Answer");
                greatAnswerResponse.text = GameManager.instance.currentQuestion.answer1response;
                GreatAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer1movement == 1)
            {
                Debug.Log("Good Answer");
                goodAnswerResponse.text = GameManager.instance.currentQuestion.answer1response;
                GoodAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer1movement == -2)
            {
                Debug.Log("bad Answer");
                badAnswerResponse.text = GameManager.instance.currentQuestion.answer1response;
                BadAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            GameManager.instance.answerNumber = 1;
        }
        else if (Button == 2)
        {
            Debug.Log("Button 2");
            if (GameManager.instance.currentQuestion.answer2movement == 2)
            {
                greatAnswerResponse.text = GameManager.instance.currentQuestion.answer2response;
                Debug.Log("Great Answer");
                GreatAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer2movement == 1)
            {
                goodAnswerResponse.text = GameManager.instance.currentQuestion.answer2response;
                Debug.Log("Good Answer");
                GoodAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer2movement == -2)
            {
                badAnswerResponse.text = GameManager.instance.currentQuestion.answer2response;
                Debug.Log("bad Answer");
                BadAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            GameManager.instance.answerNumber = 2;
        }
        else if (Button == 3)
        {
            Debug.Log("Button 3");
            if (GameManager.instance.currentQuestion.answer3movement == 2)
            {
                greatAnswerResponse.text = GameManager.instance.currentQuestion.answer3response;
                Debug.Log("Great Answer");
                GreatAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer3movement == 1)
            {
                goodAnswerResponse.text = GameManager.instance.currentQuestion.answer3response;
                Debug.Log("Good Answer");
                GoodAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            else if (GameManager.instance.currentQuestion.answer3movement == -2)
            {
                badAnswerResponse.text = GameManager.instance.currentQuestion.answer3response;
                Debug.Log("bad Answer");
                BadAnswerUI.SetActive(true);
                QuestionUI.SetActive(false);
            }
            GameManager.instance.answerNumber = 3;
        }
    }
    public void MovePlayerPhase1()
    {
        animationGameObject.GetComponent<Animator>().enabled = true;
        if (GameManager.instance.answerNumber == 1)
        {
            if (GameManager.instance.currentQuestion.answer1movement > 0)
            {
                MovePlayer(GameManager.instance.currentQuestion.answer1movement);
            }
            else
            {
                Debug.Log(Mathf.Abs(GameManager.instance.currentQuestion.answer1movement));
                MovePlayerBackWards(Mathf.Abs(GameManager.instance.currentQuestion.answer1movement));
            }
        }
        else if (GameManager.instance.answerNumber == 2)
        {
            if (GameManager.instance.currentQuestion.answer2movement > 0)
            {
                MovePlayer(GameManager.instance.currentQuestion.answer2movement);
            }
            else
            {
                Debug.Log(Mathf.Abs(GameManager.instance.currentQuestion.answer2movement));
                MovePlayerBackWards(Mathf.Abs(GameManager.instance.currentQuestion.answer2movement));
            }
        }
        else if (GameManager.instance.answerNumber == 3)
        {
            if (GameManager.instance.currentQuestion.answer3movement > 0)
            {
                MovePlayer(GameManager.instance.currentQuestion.answer3movement);
            }
            else
            {
                Debug.Log(Mathf.Abs(GameManager.instance.currentQuestion.answer3movement));
                MovePlayerBackWards(Mathf.Abs(GameManager.instance.currentQuestion.answer3movement));
            }
        }
        ButtonUI.SetActive(true);
        QuestionUI.SetActive(false);
    }

    public void MovePlayer(int move)
    {
        GameManager.instance.movementAmount = move;
        GameManager.instance.MovePlayer();
        GameManager.instance.QuestionWrong();
    }
    public void MovePlayerBackWards(int move)
    {
        GameManager.instance.movementAmount = move;
        GameManager.instance.reverse = true;
        GameManager.instance.MovePlayer();
        GameManager.instance.QuestionWrong();
    }
}
