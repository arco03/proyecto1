using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoCayendo : MonoBehaviour
{
    public float velocidadDeCaida = 0.5f;  // Ajusta la velocidad de caída según tus necesidades.

    void Update()
    {
        // Hacer que el objeto caiga gradualmente hacia abajo.
        transform.Translate(Vector3.down * velocidadDeCaida * Time.deltaTime);
    }
}
