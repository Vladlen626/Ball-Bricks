using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene:MonoBehaviour
{
    public void LoadCurrentScene(int i) {
        SceneManager.LoadScene(i);
    }
}
