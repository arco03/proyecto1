using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCamara : MonoBehaviour
{
    private bool vista;
    public Transform TPJ1;
    public Transform PPJ1;

    // Update is called once per frame
    void Update()
    {
        if (vista== false && Input.GetKeyDown(KeyCode.Space))
        {
            vista = true;
            transform.position = Vector3.Lerp(transform.position, PPJ1.position,5 * Time.deltaTime);
        }else if(vista == true && Input.GetKeyDown(KeyCode.Space))
        {
            vista = false;
            transform.position = Vector3.Lerp(transform.position, TPJ1.position,5 * Time.deltaTime);  
        }
    }
}
