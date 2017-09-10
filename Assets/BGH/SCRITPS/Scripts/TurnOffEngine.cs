using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnOffEngine : MonoBehaviour
{

    public float timeWait;
    public RCCCarControllerV2 rcc;

    public string scene;

    private void Start()
    {

    }

    bool active;
    public void OnTriggerEnter(Collider c)
    {
	    if(c.tag == "Player" && !active)
        {
            active = true;
            rcc.canControl = false;
            rcc.GetComponent<Rigidbody>().velocity = Vector3.zero;
            StartCoroutine(WaitAdver(timeWait));
        }

    }

    private IEnumerator WaitAdver(float timeWait)
    {
        yield return new WaitForSeconds(timeWait);
        SceneManager.LoadScene(scene);
        rcc.canControl = true;
    }

}
