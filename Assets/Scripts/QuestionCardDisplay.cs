using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestionCardDisplay : MonoBehaviour
{
    public QuestionCard card;


    public Text titleText;
    public TMPro.TextMeshPro questionText;
    public Text answer1Text;
    public Text answer2Text;
    public Text answer3Text;
    public Text answer4Text;



    // Start is called before the first frame update
    void Start()
    {
        titleText.text = card.title;
        questionText.text = card.question;
        answer1Text.text = card.answer1;
        answer2Text.text = card.answer2;
        answer3Text.text = card.answer3;
        answer4Text.text = card.answer4;

    }

}
