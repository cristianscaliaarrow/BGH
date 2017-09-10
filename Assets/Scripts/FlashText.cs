using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlashText : MonoBehaviour {

    public float velocity;
    public Vector3 direction;
    public float lifeTime;

	void Start()
    {
        Destroy(gameObject, lifeTime);
    }

	void Update () {
        transform.position += direction*Time.deltaTime * velocity;
	}

    public void SetText(string text)
    {
        GetComponent<Text>().text = text;
    }



  
}
