using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paneles_Camaras : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8;
    public GameObject Panel9;
    public GameObject Panel10;
    public GameObject Panel11;
    public GameObject Panel12;
    public GameObject PanelPersonaje;
    public GameObject CamaraPersonaje;
    public GameObject PanelControlCAmaras;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ControlCamaras()
    {
        PanelControlCAmaras.SetActive(true);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
     public void CamaraPanel1()
    {
        PanelControlCAmaras.SetActive(true);
        Panel1.SetActive(true);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }

    public void CamaraPanel2()
    {
        PanelControlCAmaras.SetActive(true);
        Panel1.SetActive(false);
        Panel2.SetActive(true);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }

    public void CamaraPanel3()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(true);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);

    }

    public void CamaraPanel4()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(true);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }

    public void CamaraPanel5()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(true);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel6()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(true);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel7()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(true);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel8()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(true);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel9()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(true);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel10()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(true);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel11()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(true);
        Panel12.SetActive(false);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }
    public void CamaraPanel12()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(true);
        PanelPersonaje.SetActive(false);
        CamaraPersonaje.SetActive(false);
    }

    public void CamaraPlayer()
    {
        CamaraPersonaje.SetActive(true);
        PanelPersonaje.SetActive(true);
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
        Panel6.SetActive(false);
        Panel7.SetActive(false);
        Panel8.SetActive(false);
        Panel9.SetActive(false);
        Panel10.SetActive(false);
        Panel11.SetActive(false);
        Panel12.SetActive(false);
        PanelControlCAmaras.SetActive(false);
    }

}
