using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PopUp : MonoBehaviour {
    public static PopUp instance;

    public GameObject go;
    public Text text;
    public Image image;

    public Sprite stop;
    public Sprite bonus;


    public Image wrongObject;

	// Use this for initialization
	void Awake() {
         instance = this;
	}
	
	public void ShowPopUp(string msg)
    {
        text.gameObject.SetActive(true);
        text.text = msg;
    }

    public void ShowPopUp(IconID iconId)
    {
        image.gameObject.SetActive(true);
        switch (iconId)
        {
            case IconID.STOP:
               image.sprite = stop;
                break;
            case IconID.BONUS:
                image.sprite = bonus;
                break;
            default:
                break;
        }
    }

    internal void ShowPopUp(object iconId)
    {
        throw new NotImplementedException();
    }

    public void TurnOffString()
    {
        text.gameObject.SetActive(false);
    }

    public void TurnOffIcon()
    {
        image.gameObject.SetActive(false);
    }

    public void TurnOnWrongWay()
    {
        wrongObject.enabled = true;
    }

    public void TurnOffWrongWay()
    {
        wrongObject.enabled = false;
    }
    public enum IconID
    {
        STOP,BONUS
    }
}

