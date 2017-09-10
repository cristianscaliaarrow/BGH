using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {
    public static int score;
    public float amplitude;
    public float frequency;

    private void OnTriggerEnter(Collider other)
    {
        print(++score);
        SoundManager.PlayCollectable();
        Destroy(gameObject);
        Score.ShowScore();
        GameManager.instance.ShowMoreTen();
    }

    private void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time* frequency) *amplitude * Time.deltaTime;
    }
}
