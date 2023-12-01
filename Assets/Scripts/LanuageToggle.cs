using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanuageToggle : MonoBehaviour
{
    public int LanuageValue; //The currently selected language as an int. 0 is English, 2 is French, 3 is Spanish, 4 is Italian. 
    public Image EGBox; //The image of the English Flag button
    public Image FRBox; //The image of the French Flag button
    public Image ESBox; //The image of the Spanish Flag button
    public Image ITBox; //The image of the Italian Flag button
    public TMP_Text PlayText; //The text in the play button.
    public TMP_Text LangText; //The text above the language flag buttons.

    public void Eng()
    {
        LanuageValue = 0; //Sets language to English
        EGBox.color = new Color32(255,255,255,255); //Sets the flag to default colour to show this language is being highlighted/selected.

        FRBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ESBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ITBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.

        PlayText.text = "PLAY"; //Text is set to English
        LangText.text = "LANGUAGES"; //Text is set to English
    }
    public void FR()
    {
        LanuageValue = 1; //Sets language to French
        FRBox.color = new Color32(255,255,255,255); //Sets the flag to default colour to show this language is being highlighted/selected.

        EGBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ESBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ITBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.

        PlayText.text = "JOUER"; //Text is set to French
        LangText.text = "LANGUES"; //Text is set to French
    }
    public void ES()
    {
        LanuageValue = 2; //Sets language to Spanish
        ESBox.color = new Color32(255,255,255,255); //Sets the flag to default colour to show this language is being highlighted/selected.

        FRBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        EGBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ITBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.

        PlayText.text = "JUGAR"; //Text is set to Spanish
        LangText.text = "IDIOMAS"; //Text is set to Spanish
    }
    public void IT()
    {
        LanuageValue = 3; //Sets language to Italian
        ITBox.color = new Color32(255,255,255,255); //Sets the flag to default colour to show this language is being highlighted/selected.

        FRBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        ESBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.
        EGBox.color = new Color32(60,60,60,255); //Sets this flag to a dull colour.

        PlayText.text = "GIOCO"; //Text is set to Italian
        LangText.text = "LINGUE"; //Text is set to Italian
    }
}
