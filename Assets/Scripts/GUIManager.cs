using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour {

	public Texture enemyType1Texture;
	public Texture enemyType2Texture;

    void OnGUI()
    {

		if (1 < 2 && GUI.Button (new Rect (960, 10, 50, 50), enemyType1Texture))
			return;
		if (1 < 2 && GUI.Button (new Rect (960, 80, 50, 50), enemyType2Texture))
			return;
    }
}
