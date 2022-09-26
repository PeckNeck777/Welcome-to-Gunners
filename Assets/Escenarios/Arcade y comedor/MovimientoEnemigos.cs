using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigos : MonoBehaviour
{
    public Transform TransformPlayer;
    public float speed;
    
    void Start()
    {
        //InvokeRepeating("CambioDeDireccion", 5, 5);
    }

    void Update()
    {
       // GetComponent<Rigidbody>().velocity = transform.forward;
        Distancia();

    }

    void CambioDeDireccion()
    {
        transform.Rotate(0, Random.Range(0, 90), 0);
    }

    void Seguir()
    {
        transform.position = Vector3.Lerp(transform.position, TransformPlayer.position, speed * Time.deltaTime);
    }
    void Distancia()
    {
        float dist = Vector3.Distance(transform.position, TransformPlayer.position);

        if( dist <= 3)
        {
            Seguir();
        }

    }
}
