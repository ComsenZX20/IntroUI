using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, player;
    [SerializeField]
    TMP_InputField InputPlayerName;
    [SerializeField]
    TextMeshProUGUI PlayerNameInGame;
    void Start()
    {
        screenGame.SetActive(false);
        player.SetActive(false);
        screenIntro.SetActive(true);
        Debug.Log(InputPlayerName.text);
    }

    // Update is called once per frame
    public void EmpezarJuego()
    {
        if (string.IsNullOrWhiteSpace(InputPlayerName.text))
        {
            Debug.LogError("Es necesario un nombre");
        }
        else {
            screenGame.SetActive(true);
            player.SetActive(true);
            screenIntro.SetActive(false);
            PlayerNameInGame.text = InputPlayerName.text;
        }
        
    }
}