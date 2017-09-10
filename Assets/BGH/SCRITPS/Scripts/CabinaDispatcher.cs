using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinaDispatcher : MonoBehaviour {

    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetTrigger("open");
        }
    }
}
