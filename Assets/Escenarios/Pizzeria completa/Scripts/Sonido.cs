using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public static Sonido Instance;
    [SerializeField] private AudioSource musica;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CambiarVOlumen(float value)
    {
        AudioListener.volume = value;
    }

}


