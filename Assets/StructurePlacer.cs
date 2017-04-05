using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructurePlacer : MonoBehaviour {


    public GameObject structurePrefab;
    private GameObject structure;

    private bool canPlaceStructure()
    {
        return structure == null;

    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp()
    {
        if (canPlaceStructure())
        {
            structure = (GameObject)Instantiate(structurePrefab, transform.position, Quaternion.identity);
            Debug.Log(transform.position);
            Debug.Log(structure);

        }
    }
}
