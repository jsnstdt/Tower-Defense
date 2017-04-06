using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    public GameObject[] waypoints;
    private int waypointN = 0;
    private float lastWaypointSwitchTime;
    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
        lastWaypointSwitchTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        // 1 
        Vector3 startPosition = waypoints[waypointN].transform.position;
        Vector3 endPosition = waypoints[waypointN + 1].transform.position;
        // 2 
        float pathLength = Vector3.Distance(startPosition, endPosition);
        float totalTimeForPath = pathLength / speed;
        float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, endPosition, currentTimeOnPath / totalTimeForPath);
        // 3 
        if (gameObject.transform.position.Equals(endPosition))
        {
            if (waypointN < waypoints.Length - 2)
            {
                // 3.a 
                waypointN++;
                lastWaypointSwitchTime = Time.time;
                // TODO: Rotate into move direction
            }
            else
            {
                // 3.b 
                Destroy(gameObject);
                // TODO: deduct health
            }
        }
    }
}
