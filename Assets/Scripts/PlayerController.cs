using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hecho por Jose Adolfo Martinez Olvera.

public class PlayerController : MonoBehaviour
{
    //variables privadas
    private float velocidad = 20;       //variable que mide la velocidad 
    private float turnSpeed = 25.0f;    //variable que mide la velocidad de giro
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  //hace saber al juego que se controla de izquierda a derecha segun las teclas presionadas
        forwardInput = Input.GetAxis("Vertical");       //hace saber al juego que se controla de adelante a atras segun las teclas presionadas

        // Mueve el automóvil hacia adelante según la entrada vertical
        transform.Translate(Vector3.forward * Time.deltaTime*velocidad * forwardInput);
        // Mueve el automovil de forma horizontal
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


    }
}
