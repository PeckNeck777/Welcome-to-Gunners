using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenSlider : MonoBehaviour
{
    [SerializeField] private Slider _control;
    // Start is called before the first frame update
    void Start()
    {
        Sonido.Instance.CambiarVOlumen(_control.value);
        _control.onValueChanged.AddListener(val => Sonido.Instance.CambiarVOlumen(val));
    }
}
