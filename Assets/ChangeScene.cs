using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string scene;
    public float time;

	void Start () {
        StartCoroutine(ChangeLevel());
	}

    private IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);
    }

}
