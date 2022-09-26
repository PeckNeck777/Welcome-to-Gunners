using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    [SerializeField] private GameObject canvasoficina;
    [SerializeField] private GameObject canvascamaras;

    [SerializeField] private Camera[] arraycamaras;
    [SerializeField] private Camera camaraactual;

    public void activarcamaras()
    {
        canvasoficina.SetActive(false);
        canvascamaras.SetActive(true);
        arraycamaras[0].enabled = false;
        camaraactual = arraycamaras[1];
        camaraactual.enabled = true;
    }

    public void cambicamaras(int numerocamara)
    {
        camaraactual.enabled = false;
        camaraactual = arraycamaras[numerocamara];
        camaraactual.enabled = true;

    }
    public void regreso()
    {
        canvasoficina.SetActive(true);
        canvascamaras.SetActive(false);

        cambicamaras(0);
    }
}

