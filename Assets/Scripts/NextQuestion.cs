using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextQuestion : MonoBehaviour
{
    [SerializeField] private GameObject QuestionUI;
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
        QuestionUI.SetActive(true);
    }
}
