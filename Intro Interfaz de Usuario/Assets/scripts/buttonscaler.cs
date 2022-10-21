using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscaler : MonoBehaviour
{[SerializeField]
    GameObject boton;
    // Start is called before the first frame update
    public void ScaleUp()
    {
        LeanTween.scale(boton, Vector3.one * 1.2f, 0.5f).setEaseInBounce();
    }

    // Update is called once per frame
   public void Scaledown()
    {
        LeanTween.scale(boton, Vector3.one, 0.2f);
    }
}
