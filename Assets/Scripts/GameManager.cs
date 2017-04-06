using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject[] waypoints;

    // Use this for initialization
    void Start()
    {
        Instantiate(enemyPrefab).GetComponent<MoveEnemy>().waypoints = waypoints;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
