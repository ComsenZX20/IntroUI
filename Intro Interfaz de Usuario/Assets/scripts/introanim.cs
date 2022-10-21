using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introanim : MonoBehaviour
{
    [SerializeField]
    GameObject logo;
    // Start is called before the first frame update
    void Start()
    {
        //para ocultar logo

        LeanTween.moveLocalY(logo, -350f, 0.0f);
        //para hacer aparecer el logo
        LeanTween.moveLocalY(logo, 4f, 1.0f).setEaseInElastic().setOnComplete(Latido);
        //para moverlo localmente entre ambos ejes
        //LeanTween.moveLocal(logo, new Vector3(670f,72f,0f), 1.5f)
        // LeanTween.moveLocal(logo, new Vector3(670f, 72f, 0f), 1.5f);
    }

    // Update is called once per frame
    void Latido()
    {
        LeanTween.scale(logo, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(() =>
        {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Desactivar);
        });

    }
    void Desactivar()
    {

        gameObject.SetActive(false);

    }
}
