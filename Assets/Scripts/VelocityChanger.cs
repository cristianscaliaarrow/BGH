using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VelocityChanger : MonoBehaviour {

    public float maxVelocity;
    public bool endOfTrip;

    void OnTriggerEnter(Collider c)
    {
        CarController.instance.maxVelocity = maxVelocity;
    }
}
