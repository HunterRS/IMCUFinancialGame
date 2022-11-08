using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Card", menuName = "Card/Question" )]
public class QuestionCard : ScriptableObject
{
    public string title;
    public string question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
}
