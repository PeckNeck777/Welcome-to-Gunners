using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menus : MonoBehaviour
{
    public GameObject panelmenu;
    public GameObject panelpausa;
    public GameObject paneljugar;
    public GameObject panelsonido;

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void menu1()
    {
        panelmenu.SetActive(false);
        paneljugar.SetActive(false);
        panelpausa.SetActive(true);
        panelsonido.SetActive(false);
    }

    public void menu2()
    {
        panelpausa.SetActive(false);
        panelmenu.SetActive(true);
        paneljugar.SetActive(false);
        panelsonido.SetActive(false);
    }
    public void menu3()
    {
        panelpausa.SetActive(false);
        panelmenu.SetActive(false);
        paneljugar.SetActive(true);
        panelsonido.SetActive(false);
    }
    public void menu4()
    {
        panelpausa.SetActive(false);
        panelmenu.SetActive(false);
        paneljugar.SetActive(false);
        panelsonido.SetActive(true);
    }
    public void extras()
    {
        SceneManager.LoadScene(2);
    }

}
