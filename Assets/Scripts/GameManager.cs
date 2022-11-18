using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private static GameObject player;

    public int playerStartWaypoint = 0;
    public int movementAmount = 0;
    public static bool reverse = false;
    public List<QuestionCard> easyQuestionList = new List<QuestionCard>();
    public List<QuestionCard> mediumQuestionList = new List<QuestionCard>();
    public List<QuestionCard> hardQuestionList = new List<QuestionCard>();
    public List<QuestionCard> wrongQuestionList = new List<QuestionCard>();

    public QuestionCard currentQuestion;

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
       // if (reverse == true)
       // {
      //      if (player.GetComponent<PlayerMovementPath>().waypointIndex < playerStartWaypoint - movementAmount)
      //      {
      //          player.GetComponent<PlayerMovementPath>().moveAllowed = false;
      //          playerStartWaypoint = player.GetComponent<PlayerMovementPath>().waypointIndex + 1;
      //          reverse = false;
      //      }
      //  }
            if (player.GetComponent<PlayerMovementPath>().waypointIndex > playerStartWaypoint + movementAmount)
            {
                player.GetComponent<PlayerMovementPath>().moveAllowed = false;
                playerStartWaypoint = player.GetComponent<PlayerMovementPath>().waypointIndex - 1;
            }
    }

    public static void MovePlayer()
    {
        player.GetComponent<PlayerMovementPath>().moveAllowed = true;
    }
    public void NextQuestionCard()
    {
        currentQuestion = easyQuestionList[Random.Range(0, easyQuestionList.Count - 1)];
        easyQuestionList.Remove(currentQuestion);
    }
    public void QuestionWrong()
    {
        wrongQuestionList.Add(currentQuestion);
        currentQuestion = null;
    }
}
