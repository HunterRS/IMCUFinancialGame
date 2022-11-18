using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestionCardDisplay : MonoBehaviour
{
    public static QuestionCardDisplay instance;
    [SerializeField]
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI answer1Text;
    public TextMeshProUGUI answer2Text;
    public TextMeshProUGUI answer3Text;
    public TextMeshProUGUI answer1response;
    public TextMeshProUGUI answer2response;
    public TextMeshProUGUI answer3response;



    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }
    public void NewCardDisplay()
    {
        titleText.text = GameManager.instance.currentQuestion.title;
        questionText.fontSize = GameManager.instance.currentQuestion.questionfontsize;
        questionText.text = GameManager.instance.currentQuestion.question;
        answer1Text.text = GameManager.instance.currentQuestion.answer1;
        answer2Text.text = GameManager.instance.currentQuestion.answer2;
        answer3Text.text = GameManager.instance.currentQuestion.answer3;
        answer1response.text = GameManager.instance.currentQuestion.answer1response;
        answer2response.text = GameManager.instance.currentQuestion.answer2response;
        answer3response.text = GameManager.instance.currentQuestion.answer3response;
    }
}
