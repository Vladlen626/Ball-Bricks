using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float            ballSpeed;
    public static bool      clicked;
    public float            timeToBallSpeedUp;
    public float            timer = 0;



    void Update()
    {
        SpeedUp();
        if (clicked) {
            this.transform.Translate(Vector2.up * ballSpeed * Time.deltaTime);
        } else {
            this.transform.Translate(Vector2.down * ballSpeed * Time.deltaTime);
        }
       
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Bricks") {
            _GameMainScript.tryCounts++;
            PlayerPrefs.SetInt("tryCounts", _GameMainScript.tryCounts);
            SceneManager.LoadScene(2);
            Destroy(this.gameObject);
        }
    }
    void SpeedUp() {
        timer += Time.deltaTime;
        if (timer > timeToBallSpeedUp) {
            ballSpeed += 1;
            timer = 0;
        }   
    }
}
