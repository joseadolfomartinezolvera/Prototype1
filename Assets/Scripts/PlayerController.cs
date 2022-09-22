using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hecho por Jose Adolfo Martinez Olvera.

public class PlayerController : MonoBehaviour
{
    //variables privadas
    private float velocidad = 20;
    private float turnSpeed = 25.0f; 
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime*velocidad * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


    }
}
