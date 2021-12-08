using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownDifficult : MonoBehaviour
{
    public static int difficult;
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    void DropdownItemSelected(Dropdown dropdown) {
        difficult = dropdown.value;
    }
}
