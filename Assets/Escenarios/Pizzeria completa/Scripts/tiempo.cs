using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class tiempo : MonoBehaviour
{
    public Text Hora;
    public int tiempoinicio = 0;
    public int tiempofinal = 6;

    public float duraciondelnivel = 6.0f;

    [SerializeField] float tiempoactual = 0.0f;
    
    // Start is calle0d before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoactual += Time.deltaTime;
        float tiempojuego = (tiempoactual / (duraciondelnivel * 60.0f) * (tiempofinal - tiempoinicio));
        int truncatedTimeValue = (int)tiempojuego;

        if(truncatedTimeValue == 0)
        {
            Hora.text = "12:00 AM";
        }else
        {
            Hora.text = "" + truncatedTimeValue.ToString() + ":00 AM"; 
        }

        if(truncatedTimeValue == 6)
        {
            Debug.Log("Has ganado");
      }
    }
}
