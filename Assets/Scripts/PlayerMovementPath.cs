using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    public int waypointIndex = 0;

    public bool moveAllowed = false;
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
        {
            if (GameManager.instance.reverse == true)
            {
                backwardsMove();
            }
            else
            {
                Move();
            }
        }
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, waypoints[waypointIndex].transform.position) < 0.01f)
            {
                waypointIndex += 1;
            }
        }
    }
    private void backwardsMove()
    {
        if (waypointIndex >= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waypoints[waypointIndex].transform.position) < 0.01f)
            {
                waypointIndex -= 1;
            }
        }
    }
}
