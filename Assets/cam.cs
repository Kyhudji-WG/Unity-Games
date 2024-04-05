using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cam : MonoBehaviour
{
    private Vector3 debut;
    private Vector3 deadcat;
    private cat _cat;
    void Start()
    {
        debut.x = 0;
        debut.y = 0;
        debut.z = -10;
        deadcat.x = 58;
        deadcat.y = -29;
        deadcat.z = debut.z;
        GetComponent<Transform>().position += debut;
    }

    // Update is called once per frame
    void Update()
    {
        if (_cat.dead == true)
        {
            GetComponent<Transform>().position += deadcat;
        }
    }
}
