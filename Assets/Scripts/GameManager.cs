using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public GameObject ten;
    public GameObject minusTen;
    public Transform flashPosition;

	void Start () {
        instance = this;
	}
	
    public void ShowMoreTen()
    {
        Transform t = GameObject.Find("Player").transform;
        GameObject flashTxt = ((GameObject)Instantiate(ten, flashPosition.transform.TransformPoint(Vector3.zero), Quaternion.identity));
        flashTxt.gameObject.transform.eulerAngles = t.eulerAngles;
        flashTxt.transform.parent = flashPosition;
    }

    public void ShowMinusTen()
    {
        Transform t = GameObject.Find("Player").transform;
        GameObject flashTxt = ((GameObject)Instantiate(minusTen, flashPosition.transform.TransformPoint(Vector3.zero), Quaternion.identity));
        flashTxt.gameObject.transform.eulerAngles = t.eulerAngles;
        flashTxt.transform.parent = flashPosition;
    }
}

