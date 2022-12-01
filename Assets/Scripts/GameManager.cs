using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private GameObject player, canvasforfinishinggame;

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

    public int checkpoint = 0;

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
                if (playerStartWaypoint < 0 || player.GetComponent<PlayerMovementPath>().waypointIndex < 0)
                {
                    playerStartWaypoint = 0;
                    player.GetComponent<PlayerMovementPath>().waypointIndex = 0;
                    return;
                }
            }
        }
            if (player.GetComponent<PlayerMovementPath>().waypointIndex > playerStartWaypoint + movementAmount)
            {
                player.GetComponent<PlayerMovementPath>().moveAllowed = false;
                lastMoveReverse = false;
                playerStartWaypoint = player.GetComponent<PlayerMovementPath>().waypointIndex - 1;
                CheckCheckpoints();
            }
            if (player.GetComponent<PlayerMovementPath>().waypointIndex == player.GetComponent<PlayerMovementPath>().waypoints.Length)
        {
            canvasforfinishinggame.gameObject.SetActive(true);
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
        if (GameValues.difficulty == "easy" )
        {
            if (easyQuestionList.Count == 0)
            {
                easyQuestionList.Add(wrongQuestionList[0]);
                wrongQuestionList.Clear();
            }
            currentQuestion = easyQuestionList[Random.Range(0, easyQuestionList.Count - 1)];
            easyQuestionList.Remove(currentQuestion);
        }
        if (GameValues.difficulty == "medium")
        {
            if (mediumQuestionList.Count == 0)
            {
                mediumQuestionList.Add(wrongQuestionList[0]);
                wrongQuestionList.Clear();
            }
            currentQuestion = mediumQuestionList[Random.Range(0, mediumQuestionList.Count - 1)];
            mediumQuestionList.Remove(currentQuestion);
        }
        if (GameValues.difficulty == "hard")
        {
            if (hardQuestionList.Count == 0)
            {
                hardQuestionList.Add(wrongQuestionList[0]);
                wrongQuestionList.Clear();
            }
            currentQuestion = hardQuestionList[Random.Range(0, hardQuestionList.Count - 1)];
            hardQuestionList.Remove(currentQuestion);
        }

    }
    public void QuestionWrong()
    {
        wrongQuestionList.Add(currentQuestion);
        currentQuestion = null;
    }

    public void CheckCheckpoints()
    {
        if (playerStartWaypoint >= 4)
        {
            checkpoint = 5;
        }
        if (playerStartWaypoint >= 16)
        {
            checkpoint = 17;
        }
        if (playerStartWaypoint >= 32)
        {
            checkpoint = 33;
        }
    }
}
