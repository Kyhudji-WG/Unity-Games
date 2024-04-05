using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feet : MonoBehaviour
{
    public bool Ingrouded;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "sol")
        {
            Ingrouded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "sol")
        {
            Ingrouded = false;
        }
    }
}
