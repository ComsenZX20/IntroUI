using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelanguage : MonoBehaviour
{
    int idiomaActual = 0;
    // Start is called before the first frame update
    private void Start()
    {
        SelectCurrentLang();
    }

    // Update is called once per frame
    void SelectCurrentLang()
    {
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[idiomaActual];


        while (searcher != LocalizationSettings.SelectedLocale && idiomaActual < LocalizationSettings.AvailableLocales.Locales.Count)
        { idiomaActual++;
            searcher = LocalizationAssetSettings.AvailableLocales.Locales[idiomaActual];
        }
    }
}
