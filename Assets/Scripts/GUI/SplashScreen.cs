using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	void Update () {
        if (Input.GetAxis("Vertical") > 0.5f)
        {
            SceneManager.LoadScene("SelectMenu");
        }
    }
}
