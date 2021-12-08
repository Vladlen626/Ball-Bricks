using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectDifficult : MonoBehaviour
{
    public List<Difficult> difficultsList;
    public static Difficult difficult;


    void Start()
    {
        difficult = difficultsList[0];
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    void DropdownItemSelected(Dropdown dropdown) {
        difficult = difficultsList[dropdown.value];
    }
}
