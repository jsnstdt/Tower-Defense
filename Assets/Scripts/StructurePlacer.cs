using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructurePlacer : MonoBehaviour {


    public GameObject structurePrefab;
    private GameObject structure;
    SpriteRenderer sr;

    private bool canPlaceStructure()
    {
        return structure == null;

    }

	private bool canUpgradeStructure() {
		if (structure != null) {
			StructureData structureData = structure.GetComponent<StructureData> ();
			StructureLevel nextLevel = structureData.getNextLevel ();
			if (nextLevel != null) {
				return true;
			}
		}
		return false;
	}

	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnMouseUp()
    {
		if (canPlaceStructure ()) {
			structure = (GameObject)Instantiate (structurePrefab, transform.position, Quaternion.identity);
			sr.enabled = false;

		} else if (canUpgradeStructure ()) {
			structure.GetComponent<StructureData> ().increaseLevel ();
		}
    }
}
