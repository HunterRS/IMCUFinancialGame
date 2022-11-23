using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private GameObject player;

    public int playerStartWaypoint = 0;
    public int movementAmount = 0;
    public bool reverse = false;
    public bool lastMoveReverse = false;
    public List<QuestionCard> easyQuestionList = new List<QuestionCard>();
    public List<QuestionCard> mediumQuestionList = new List<QuestionCard>();
    public List<QuestionCard> hardQuestionList = new List<QuestionCard>();
    public List<QuestionCard> wrongQuestionList = new List<QuestionCard>();

    public QuestionCard currentQuestion;

    public int answerNumber;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (reverse == true)
        {
            if (player.GetComponent<PlayerMovementPath>().waypointIndex < playerStartWaypoint - movementAmount)
            {
                player.GetComponent<PlayerMovementPath>().moveAllowed = false;
                lastMoveReverse = true;
                playerStartWaypoint = player.GetComponent<PlayerMovementPath>().waypointIndex + 1;
                reverse = false;
            }
        }
            if (player.GetComponent<PlayerMovementPath>().waypointIndex > playerStartWaypoint + movementAmount)
            {
                player.GetComponent<PlayerMovementPath>().moveAllowed = false;
                lastMoveReverse = false;
                playerStartWaypoint = player.GetComponent<PlayerMovementPath>().waypointIndex - 1;
            }
    }

    public void MovePlayer()
    {
        if (lastMoveReverse != reverse)
        {
            if (reverse == true)
            {
                player.GetComponent<PlayerMovementPath>().waypointIndex -= 2;
            }
            else
            {
                player.GetComponent<PlayerMovementPath>().waypointIndex += 2;
            }
        }
        player.GetComponent<PlayerMovementPath>().moveAllowed = true;
    }
    public void NextQuestionCard()
    {
        currentQuestion = easyQuestionList[Random.Range(0, easyQuestionList.Count - 1)];
        easyQuestionList.Remove(currentQuestion);
        //if (mediumQuestionList.Count == 0)
        //{
         //   mediumQuestionList.Add(wrongQuestionList[0]);
         //   wrongQuestionList.Clear();
        //}
        //currentQuestion = mediumQuestionList[0];
       // mediumQuestionList.Remove(currentQuestion);
    }
    public void QuestionWrong()
    {
        wrongQuestionList.Add(currentQuestion);
        currentQuestion = null;
    }
}
