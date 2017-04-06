using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject[] waypoints;
	public int currentStructureType;
	private int gold;
	public Text goldLabel;

	public int Gold {
		get { return gold; }
		set {
			gold = value;
			goldLabel.GetComponent<Text> ().text = "Money: " + gold;
		}
	}


    // Use this for initialization
    void Start()
    {
        Instantiate(enemyPrefab).GetComponent<MoveEnemy>().waypoints = waypoints;
		Gold = 1000;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
