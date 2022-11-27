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
    }
}
