using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
  public GameObject electricidad;
    public GameObject electricidad2;
    public AudioSource shock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shockelectrico();
    }

    public void shockelectrico()
    {
        if (Input.GetKey(KeyCode.E))
        {
          electricidad.SetActive(true);
            electricidad2.SetActive(true);
            shock.Play();
        }
    }
}
