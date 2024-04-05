using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class damage : MonoBehaviour
{
    public int life;
    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TakeDamage(-1);
        }
    }
}
