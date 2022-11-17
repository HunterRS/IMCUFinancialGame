using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestionCardDisplay : MonoBehaviour
{
    public QuestionCard card;


    public TextMeshProUGUI titleText;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI answer1Text;
    public TextMeshProUGUI answer2Text;
    public TextMeshProUGUI answer3Text;
    public TextMeshProUGUI answer4Text;



    // Start is called before the first frame update
    void Start()
    {
        titleText.text = card.title;
        //titleText.fontSize = GameManager.currentQuestion.questionfontsize;
        questionText.text = card.question;
        answer1Text.text = card.answer1;
        answer2Text.text = card.answer2;
        answer3Text.text = card.answer3;

    }
 
}
