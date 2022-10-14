using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






public class ImageFiller : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }
    //Nueva funcion que rellena el icono

    public void Fill(float valor)
    {
        image.fillAmount += valor;
    }


    //Nueva funcion que disminuye en -0.1f el icono
    // Update is called once per frame
  
}
