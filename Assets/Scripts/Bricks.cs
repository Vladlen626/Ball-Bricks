using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    [SerializeField]private float bricksSpeed; 
  
    void FixedUpdate()
    {
        this.transform.Translate(Vector2.left * bricksSpeed * Time.deltaTime);
        if(this.transform.position.x < -9.5f) {
            this.gameObject.SetActive(false);
        }
    }
}
