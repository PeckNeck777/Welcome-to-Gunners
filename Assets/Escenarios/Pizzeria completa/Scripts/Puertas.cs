using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject puertaDerecha;
    public Animator animator;
    public AudioSource abrir;
    public AudioSource cerrar;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        cerrarouertas();
        
}
    public void cerrarouertas()
    {
        bool Puerta = animator.GetBool("cerrar");
        bool KPressed = Input.GetKey(KeyCode.K);
        bool LPressed = Input.GetKey(KeyCode.L);

        if (KPressed && !Puerta)
        {
            animator.SetBool("cerrar", true);
            cerrar.Play();

        }

        if (LPressed && Puerta)
        {
            animator.SetBool("cerrar", false);
            abrir.Play();
        }

      
    }
}
