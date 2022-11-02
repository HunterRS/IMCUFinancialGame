using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private static GameObject player;

    public static int playerStartWaypoint = 0;
    public static int movementAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
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
}
