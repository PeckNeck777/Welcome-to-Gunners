using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misionllevarplato : MonoBehaviour
{
    public GameObject plato1;
    public GameObject plato2;
    public GameObject plato3;

    private void OnTriggerEnter(Collider other)
    {
       if (other.transform.tag == "Player")
        {
            Destroy(plato1);
            Destroy(plato2);
            Destroy(plato3);
        }
    }
}
