using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksPool : MonoBehaviour
{
    public static BricksPool instance;

    private List<GameObject> pooledBricks = new List<GameObject>();
    private int bricksCount = 10;

    [SerializeField] private GameObject brickPrefab;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }    
    }

    void Start()
    {
        for (int i = 0; i < bricksCount; i++) {
            GameObject go = Instantiate(brickPrefab);
            go.SetActive(false);
            pooledBricks.Add(go);
        }
    }

    public GameObject GetBrickFromPool() {
        for (int i = 0; i < pooledBricks.Count; i++) {
            if (!pooledBricks[i].activeInHierarchy) {
                return pooledBricks[i];
            }
        }
        return null;
    }
}
