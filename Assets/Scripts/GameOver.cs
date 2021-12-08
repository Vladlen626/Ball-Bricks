using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]private GameObject lastTryGO; 
    [SerializeField]private GameObject countsTryGO;
    void Start()
    {
        Text lastTryText = lastTryGO.GetComponent<Text>();
        lastTryText.text = "Try duration: " + _GameMainScript.tryTime + " sec";

        Text countsTryText = countsTryGO.GetComponent<Text>();
        countsTryText.text = "Try counts: " + _GameMainScript.tryCounts;
    }
}
