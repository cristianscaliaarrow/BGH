using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static Score instance;

	void Start () {
        instance = this;
	}
	
	public static void ShowScore()
    {
        GameManager.instance.ShowMoreTen();
    }
}
