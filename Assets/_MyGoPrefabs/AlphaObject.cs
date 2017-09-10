using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlphaObject : MonoBehaviour {

    public float amount;
    public Image image;
	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        Color c = image.color;
        c.a -= amount * Time.deltaTime;
        if (c.a < 0) c.a = 0;
        image.color = c;
	}
}
