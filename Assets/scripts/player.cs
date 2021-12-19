using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Joystick cam;

    // Update is called once per frame
    void FixedUpdate()
    {

        var x = cam.Horizontal * Time.deltaTime * 100.0f;
        var y = cam.Vertical * Time.deltaTime * 10.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, y);
    }
}