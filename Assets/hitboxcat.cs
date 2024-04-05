using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxcat : MonoBehaviour
{
    public bool colbox;
    public bool colsol;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "box")
        {
            colbox = true;
        }
        if (collision.tag == "sol")
        {
            colsol = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "box")
        {
            colbox = false;
        }
        if (collision.tag == "sol")
        {
            colsol = false;
        }
    }
}
