using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffEngine : MonoBehaviour
{

    public Animator advertisement;
    Renderer renderer;
    public Texture texture;
    public float timeWait;
    public Animator trafficLight;
    public RCCCarControllerV2 rcc;
    private void Start()
    {
        advertisement = GetComponentInChildren<Animator>();
        renderer = advertisement.GetComponentInChildren<Renderer>();
        renderer.material.mainTexture = texture;
        renderer.enabled = false;
    }

    bool active;
    public void OnTriggerEnter(Collider c)
    {
	    if(c.tag == "Player" && !active)
        {
            active = true;
            renderer.enabled = true;
            advertisement.enabled = true;
            rcc.canControl = false;
            rcc.GetComponent<Rigidbody>().velocity = Vector3.zero;
            advertisement.SetTrigger("open");
            StartCoroutine(WaitAdver(timeWait));
        }

    }

    private IEnumerator WaitAdver(float timeWait)
    {
        yield return new WaitForSeconds(timeWait);
        renderer.enabled = false;
        rcc.canControl = true;
        trafficLight.enabled = true;
        trafficLight.SetTrigger("open");
}
}
