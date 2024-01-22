using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public string horizontalAxes;
    public string verticalAxes;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        x = Input.GetAxisRaw(horizontalAxes);
        y = Input.GetAxisRaw(verticalAxes);
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
    }
}
