using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class StructureType
{
    public int[] cost;
    public Sprite[] sprites;
}

public StructureType CurrentLevel
{
    get
    {
        return currentLevel;
    }
}


public class StructureData : MonoBehaviour {

    public List<StructureType> types;
    private StructureLevel currentLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
