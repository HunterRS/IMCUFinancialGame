using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextQuestion : MonoBehaviour
{
    [SerializeField] private GameObject QuestionPrefabUI;
    [SerializeField] private GameObject QuestionUI;
    [SerializeField] private GameObject AnswerUI1;
    [SerializeField] private GameObject AnswerUI2;
    [SerializeField] private GameObject AnswerUI3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void activateNextQuestion()
    {
        this.gameObject.SetActive(false);
        AnswerUI1.SetActive(false);
        AnswerUI2.SetActive(false);
        AnswerUI3.SetActive(false);
        QuestionPrefabUI.SetActive(true);
        QuestionUI.SetActive(true);
        GameManager.instance.NextQuestionCard();
        QuestionCardDisplay.instance.NewCardDisplay();
    }
    public void MovePlayer()
    {
        GameManager.instance.movementAmount = 2;
        GameManager.instance.MovePlayer();
    }
    public void MovePlayerBackWards()
    {
        GameManager.instance.movementAmount = 2;
        GameManager.instance.reverse = true;
        GameManager.instance.MovePlayer();
    }
}
