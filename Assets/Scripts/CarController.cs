using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
    public static CarController instance;

    public float time;

    public float velocity;
    public float maxVelocity = 60;

    public float score;

    public float timeToDiscount = 1;
    public float penaltyTime;
    private float crrTime;
    public float Real_MaxSpeed;

	// Use this for initialization
	void Start () {
        instance = this;
	}

    // Update is called once per frame
    void Update() {

        time += Time.deltaTime;
        crrTime += Time.deltaTime;
        velocity = RCCUIDashboardDisplay.instance.inputs.KMH;
        if (velocity > maxVelocity)
        {
            if(crrTime >= timeToDiscount){
                crrTime = 0;
                time += penaltyTime;
                GameManager.instance.ShowMinusTen();
            }
            PopUp.instance.ShowPopUp("Reduce Speed!");
            PopUp.instance.ShowPopUp(PopUp.IconID.STOP);
        }
        else {
            PopUp.instance.TurnOffString();
            PopUp.instance.TurnOffIcon();
        }

    }
}
