using UnityEngine;
using System.Collections;

public class sun : MonoBehaviour {
    public float speed;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        pos = transform.parent.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround(pos,Vector3.right,speed*Time.deltaTime);
	}
}
