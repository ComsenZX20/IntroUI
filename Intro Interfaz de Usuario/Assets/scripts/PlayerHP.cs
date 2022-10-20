using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    float MAX_HEALTH = 20f;
    [SerializeField]
    float healthPlayer = 5;
    [SerializeField]
    Slider sliderHealth;
    // Start is called before the first frame update
    void Start()
    {
        sliderHealth.maxValue = MAX_HEALTH;
        //Valor del slider a la mitad de MAX_HEALTH
        sliderHealth.value = MAX_HEALTH / 2;
    }

    // Update is called once per frame
    public void Fill(float valor)
    {
        sliderHealth.value += valor;
    }
}
