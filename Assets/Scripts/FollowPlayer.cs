using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;                       //variable GameObject para agregar al player a la camara
    private Vector3 offset = new Vector3(0, 5 ,-7); //convierte el desplazamiento en una variable Vector3

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Sirve para obtener la transform.position de la cama actual
        transform.position = player.transform.position + offset;
    }
}
