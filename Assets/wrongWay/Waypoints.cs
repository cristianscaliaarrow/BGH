using UnityEngine;
using System.Collections;

public class Waypoints : MonoBehaviour {

    public static Transform _direction;

    private GameObject player;
    public bool initial;

    void Awake()
    {
        if (initial) _direction = transform;
        player = GameObject.Find("Player");
    }

	void Update () {
        Vector3 v = player.transform.position;
        v.y = _direction.position.y;
        float angle = (Vector3.Dot(_direction.forward, player.transform.forward));
        if(angle < -0.5)
        {
            PopUp.instance.TurnOnWrongWay();
        }
        else
        {
            PopUp.instance.TurnOffWrongWay();
        }
	}

    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            _direction = transform;
        }
    }
}
