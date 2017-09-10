using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;


    public static GameModeId gameMode = GameModeId.PREPAGO;

    public GameObject ten;
    public GameObject minusTen;
    public Transform flashPosition;
    public Vector3 offSetPosition;
    public float minutesForRound;

	// Use this for initialization
	void Start () {
        instance = this;
        print(" MODE SELECTED " + gameMode);
	}
	
	// Update is called once per frame
	void Update () {
        if(CarController.instance.time / 60 > minutesForRound)
        {
            EndLevel();
        }
	}

    public void EndLevel()
    {
        int segundos = (int)CarController.instance.time;
        int min = segundos / 60;
        segundos -= min * 60;
        print("time Total " + min + ":" + segundos);
        SceneManager.LoadScene("GameOver");
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

public enum GameModeId
{
    PREPAGO,DEBITO
}