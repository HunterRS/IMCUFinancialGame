using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerButtonUI : MonoBehaviour
{
    public TextMeshProUGUI answer1Text;
    public TextMeshProUGUI answer2Text;
    public TextMeshProUGUI answer3Text;
    public GameObject answer1Button;
    public GameObject answer2Button;
    public GameObject answer3Button;



    public void AnswerDisplayPart1()
    {
        answer1Button.SetActive(false);
        answer2Button.SetActive(false);
        answer3Button.SetActive(false);
        this.GetComponent<Animator>().enabled = true;
    }

    public void AnswerDisplayPart3()
    {
        this.GetComponent<Animator>().enabled = false;

        answer1Text.text = GameManager.instance.currentQuestion.answer1;
        answer1Button.SetActive(true);
        answer2Text.text = GameManager.instance.currentQuestion.answer2;
        answer2Button.SetActive(true);
        if (GameManager.instance.currentQuestion.answer3 == null || GameManager.instance.currentQuestion.answer3 == "")
        {
            answer3Button.SetActive(false);
        }
        else
        {
            answer3Text.text = GameManager.instance.currentQuestion.answer3;
            answer3Button.SetActive(true);
        }
    }
}
