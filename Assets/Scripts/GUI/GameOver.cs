using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public float timeToEnd;

    public Text txtScore;

	void Start () {
        StartCoroutine(EndGame());
        //print("totla Seg " + GameManager.instance.minutesForRound * 60 + "crr seg " + (int)CarController.instance.time);
        txtScore.text = Collectable.score+"";
	}

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(timeToEnd);
        SceneManager.LoadScene("Welcom");
    }
}
