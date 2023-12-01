using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanuageToggle : MonoBehaviour
{
    public int LanuageValue;
    public Image EGBox;
    public Image FRBox;
    public Image ESBox;
    public Image ITBox;
    public TMP_Text PlayText;
    public TMP_Text LangText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Eng()
    {
        LanuageValue = 0;
        EGBox.color = new Color32(255,255,255,255);

        FRBox.color = new Color32(60,60,60,255);
        ESBox.color = new Color32(60,60,60,255);
        ITBox.color = new Color32(60,60,60,255);

        PlayText.text = "PLAY";
        LangText.text = "LANGUAGES";
    }
    public void FR()
    {
        LanuageValue = 1;
        FRBox.color = new Color32(255,255,255,255);

        EGBox.color = new Color32(60,60,60,255);
        ESBox.color = new Color32(60,60,60,255);
        ITBox.color = new Color32(60,60,60,255);

        PlayText.text = "JOUER";
        LangText.text = "LANGUES";
    }
    public void ES()
    {
        LanuageValue = 2;
        ESBox.color = new Color32(255,255,255,255);

        FRBox.color = new Color32(60,60,60,255);
        EGBox.color = new Color32(60,60,60,255);
        ITBox.color = new Color32(60,60,60,255);

        PlayText.text = "JUGAR";
        LangText.text = "IDIOMAS";
    }
    public void IT()
    {
        LanuageValue = 3;
        ITBox.color = new Color32(255,255,255,255);

        FRBox.color = new Color32(60,60,60,255);
        ESBox.color = new Color32(60,60,60,255);
        EGBox.color = new Color32(60,60,60,255);

        PlayText.text = "GIOCO";
        LangText.text = "LINGUE";
    }
}
