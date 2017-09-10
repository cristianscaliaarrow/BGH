using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurOffGo : MonoBehaviour {
    public GameObject go;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            go.SetActive(false);
        }
    }
}
