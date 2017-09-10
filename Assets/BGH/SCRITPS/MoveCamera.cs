using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {


    void Start() {
        if(PlayerPrefs.GetFloat("poscamx")!=0)
            transform.position = new Vector3(PlayerPrefs.GetFloat("poscamx"), PlayerPrefs.GetFloat("poscamy"), PlayerPrefs.GetFloat("poscamz"));
    }

       
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime/2;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime/2;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime/2;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime/2;
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            transform.position += transform.up * Time.deltaTime / 2;
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            transform.position -= transform.up * Time.deltaTime / 2;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.SetFloat("poscamx", transform.position.x);
            PlayerPrefs.SetFloat("poscamy", transform.position.y);
            PlayerPrefs.SetFloat("poscamz", transform.position.z);
        }
    }
}
