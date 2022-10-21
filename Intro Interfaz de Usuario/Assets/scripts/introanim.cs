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

        LeanTween.moveLocalY(logo, -300f, 0.0f);
        //para hacer aparecer el logo
        LeanTween.moveLocalY(logo, 4f, 0.0f);
        //para moverlo localmente entre ambos ejes
        //LeanTween.moveLocal(logo, new Vector3(670f,72f,0f), 1.5f)
        LeanTween.moveLocal(logo, new Vector3(15f, 0f, 0f), 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
