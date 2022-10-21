using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablemenu : MonoBehaviour
{
    [SerializeField]
    GameObject logo;
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.moveLocalY(logo, 400f, 0.0f);
        //para hacer aparecer el logo
        LeanTween.moveLocalY(logo, 110f, 0.5f);
        LeanTween.moveLocalY(logo, 110f, 5f).setEaseInBounce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
