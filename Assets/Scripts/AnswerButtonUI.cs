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

    public Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void AnswerDisplayPart1()
    {
        answer1Button.SetActive(false);
        answer2Button.SetActive(false);
        answer3Button.SetActive(false);
        Debug.Log(answer1Button.activeSelf);
        Debug.Log(answer2Button.activeSelf);
        Debug.Log(answer3Button.activeSelf);
    }
    public void AnswerDisplayPart2()
    {
        answer1Button.SetActive(true);
        answer2Button.SetActive(true);
        answer3Button.SetActive(true);
    }

    public void AnswerDisplayPart3()
    {
        anim = GetComponent<Animation>();
        if (GameManager.instance.currentQuestion.answer2 == "")
        {
            answer1Button.SetActive(false);
        }
        else
        {
            answer1Text.text = GameManager.instance.currentQuestion.answer1;
            answer1Button.SetActive(true);
        }
        if (GameManager.instance.currentQuestion.answer2 == null)
        {
            answer2Button.SetActive(false);
        }
        else
        {
            answer2Text.text = GameManager.instance.currentQuestion.answer2;
            answer2Button.SetActive(true);
        }
        if (GameManager.instance.currentQuestion.answer3 == null || GameManager.instance.currentQuestion.answer3 == "")
        {
            Debug.Log("Yes");
            answer3Button.SetActive(false);
            Debug.Log(answer3Button.activeSelf);
        }
        else
        {
            Debug.Log("No");
            answer3Text.text = GameManager.instance.currentQuestion.answer3;
            answer3Button.SetActive(true);
        }
        answer3Button.SetActive(false);
        this.GetComponent<Animator>().enabled = false;
    }
}
