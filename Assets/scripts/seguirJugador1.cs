using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirJugador1 : MonoBehaviour
{
    public GameObject personaje1;

    // Update is called once per frame
    void Update()
    {
        transform.position = personaje1.transform.position + new Vector3(1.65999997f, 4.92000008f, -7f);       
    }
}

