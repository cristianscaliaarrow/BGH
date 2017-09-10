using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour {

	void Update () {
        if (Input.GetAxis("Vertical") > 0.8f)
        {
            SceneManager.LoadScene("GamePlay");
        }
	}
}
