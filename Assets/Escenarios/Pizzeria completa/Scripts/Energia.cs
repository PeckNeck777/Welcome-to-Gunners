using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energia : MonoBehaviour
{
    public Text energia;
    public float porcentaje = 100.0f;
    public GameObject Panel;
    public GameObject Luzoficina;
    public GameObject Luznatural;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energia.text = "Energia: "+ porcentaje.ToString("0") + "%";
        porcentaje -= Time.deltaTime/3;

        if(porcentaje == 0)
        {
           energia.enabled = false;
           Panel.SetActive(false);
           Luznatural.SetActive(false);
           Luzoficina.SetActive(false);
        }

    }
}
