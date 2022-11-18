using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Card", menuName = "Card/Question" )]
public class QuestionCard : ScriptableObject
{
    public string title;
    public string question;
    public float questionfontsize;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer1response;
    public float answer1fontsize;
    public int answer1movement;
    public string answer2response;
    public float answer2fontsize;
    public int answer2movement;
    public string answer3response;
    public float answer3fontsize;
    public int answer3movement;

    // 1 for Best Answer, 2 for Okay 3 For Bad Answer
    public int Answer1Right;
    public int Answer2Right;
    public int Answer3Right;
}
