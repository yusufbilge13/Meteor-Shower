using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleMovement : MonoBehaviour
{
    public float time;
    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        Vector2 movement = new Vector2(1, 0);
        movement.Normalize();
        transform.Translate(movement * 2.0f * Time.deltaTime);
    }
}
