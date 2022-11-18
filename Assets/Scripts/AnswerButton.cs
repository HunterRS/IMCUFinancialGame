using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private int AnswerNum;
    [SerializeField] private GameObject QuestionUI;
    [SerializeField] private GameObject AnswerUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerQuestion()
    {
        AnswerUI.SetActive(false);
        QuestionUI.SetActive(true);
    }
    public void MovePlayer()
    {
        GameManager.instance.movementAmount = 3;
        GameManager.MovePlayer();
        GameManager.instance.QuestionWrong();
    }
    public void MovePlayerBackWards()
    {
        GameManager.instance.movementAmount = 2;
        GameManager.reverse = true;
        GameManager.MovePlayer();
        GameManager.instance.QuestionWrong();
    }
}
