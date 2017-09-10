using UnityEngine;
using System.Collections;

public class PeajeDispatcher : MonoBehaviour {

    public GameObject bar;

    public bool barActive;

	void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            barActive = true;
           
        }
    }

    void Update()
    {
        if (barActive)
        {
            bar.transform.eulerAngles += Vector3.right*2.7f;
            if (bar.transform.eulerAngles.x > 340) barActive = false;
        }
    }
}
