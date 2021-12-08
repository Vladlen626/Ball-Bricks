using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameMainScript : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject       ballPrefab;
    public Vector2          ballStartPos;
    public float            bricksSpawnPerSecond;
    public static float     tryTime;
    public static int       tryCounts;


    void Start()
    {
        tryTime = 0;
        SpawnBall();
        Invoke("SpawnBrick", 1f / bricksSpawnPerSecond);
    }

    private void Update() {
        Timer();
        TryCounter();
    }

    void TryCounter() {
        if (PlayerPrefs.HasKey("tryCounts")) {
            tryCounts = PlayerPrefs.GetInt("tryCounts");
        } else {
            tryCounts = 0;
            PlayerPrefs.SetInt("tryCounts", tryCounts);
        }
    }

    void SpawnBrick() {
        GameObject brick = BricksPool.instance.GetBrickFromPool();

        if (brick != null) {
            brick.transform.position = new Vector2(9.5f, Random.Range(-1f, 3f));
            brick.SetActive(true);
        }

        Invoke("SpawnBrick", 1f / bricksSpawnPerSecond);
    }

    void SpawnBall() {
        Instantiate(ballPrefab, ballStartPos, Quaternion.identity);
    }

    void Timer() {
        tryTime += Time.deltaTime;
    }
}
