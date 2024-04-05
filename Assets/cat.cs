using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float speed;
    public float powerjump;
    public bool dead = false;
    void Update()
    {
        GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
        Vector2 currentVelocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            currentVelocity.x += -speed;
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            currentVelocity.x += speed;
        }
        GetComponent<Rigidbody2D>().velocity = currentVelocity;

        if (Input.GetKeyDown(KeyCode.Mouse2) && GetComponent<Transform>().GetChild(0).GetComponent<feet>().Ingrouded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * powerjump);
        }
        if (GetComponent<Transform>().GetChild(1).GetComponent<hitboxcat>().colsol == true && GetComponent<Transform>().GetChild(1).GetComponent<hitboxcat>().colbox == true)
        {
            Destroy(this.gameObject);
            dead = true;
        }

    }
    
}
