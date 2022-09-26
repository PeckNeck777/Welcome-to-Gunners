using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EXtras : MonoBehaviour
{

    public GameObject panelGunner;
    public GameObject panelHippo;
    public GameObject panelJessie;
    public GameObject panelRyder;
    public GameObject panelSkull;

    public void gunner()
    {
        panelGunner.SetActive(true);
        panelHippo.SetActive(false);
        panelJessie.SetActive(false);
        panelRyder.SetActive(false);
        panelSkull.SetActive(false);
    }
    public void hippo()
    {
        panelGunner.SetActive(false);
        panelHippo.SetActive(true);
        panelJessie.SetActive(false);
        panelRyder.SetActive(false);
        panelSkull.SetActive(false);
    }
    public void jessie()
    {
        panelGunner.SetActive(false);
        panelHippo.SetActive(false);
        panelJessie.SetActive(true);
        panelRyder.SetActive(false);
        panelSkull.SetActive(false);
    }
    public void ryder()
    {
        panelGunner.SetActive(false);
        panelHippo.SetActive(false);
        panelJessie.SetActive(false);
        panelRyder.SetActive(true);
        panelSkull.SetActive(false);
    }
    public void skull()
    {
        panelGunner.SetActive(false);
        panelHippo.SetActive(false);
        panelJessie.SetActive(false);
        panelRyder.SetActive(false);
        panelSkull.SetActive(true);
    }

    public void regresar()
    {
        SceneManager.LoadScene(0);
    }
}
