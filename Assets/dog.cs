using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class dog : MonoBehaviour
{
    public float speed;
    public float powerjump;

    void Update()
    {
        GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
        Vector2 currentVelocity = new Vector2(0,GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetKey(KeyCode.D))
        {
            currentVelocity.x += speed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            currentVelocity.x += -speed;
        }
        GetComponent<Rigidbody2D>().velocity = currentVelocity;

        if (Input.GetKeyDown(KeyCode.Z) && GetComponent<Transform>().GetChild(0).GetComponent<feet>().Ingrouded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * powerjump);
        }

    }
    

}
