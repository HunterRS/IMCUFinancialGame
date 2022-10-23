using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private int AnswerNum;
    [SerializeField] private GameObject nextQuestionButton;
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
        nextQuestionButton.SetActive(true);
    }
}
