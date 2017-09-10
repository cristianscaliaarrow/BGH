using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VelocityChanger : MonoBehaviour {

    public float maxVelocity;
    public bool endOfTrip;

    void OnTriggerEnter(Collider c)
    {
        if (endOfTrip) GameManager.instance.EndLevel();
        CarController.instance.maxVelocity = maxVelocity;
    }
}
