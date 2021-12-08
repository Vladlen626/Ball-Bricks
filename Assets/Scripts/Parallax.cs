using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float        endX;
    public float        startX;
    public float        gameSpeed;

    void FixedUpdate() {
        this.transform.Translate(Vector2.left * SelectDifficult.difficult.ballSpeed * Time.deltaTime);
        if (this.transform.position.x < endX) {
            Vector2 pos = new Vector2 (startX, this.transform.position.y);
            this.transform.position = pos;
        }
        
    }
}
