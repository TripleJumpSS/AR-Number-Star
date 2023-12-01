using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScreenLang : MonoBehaviour
{
    public int LanuageValue; //The language as taken from the GameManager. 0 is English, 2 is French, 3 is Spanish, 4 is Italian. 
    public TMP_Text GreatText; //Text that says "SUPERB" on the win screen in various languages.
    public TMP_Text PoppedText; //Text that says "YOU POPPED:" on the win screen in various languages.
    public TMP_Text GradeText; //Text that says "GRADE:" on the win screen in various languages.v
    public TMP_Text ReplayText; //Text that says "REPLAY" on the win screen in various languages.
    public GameObject GameManager; //Where LanguageValue is taken from
    void Awake()
    {
        LanuageValue = GameManager.GetComponent<GameManager>().LanuageValue;
        switch (LanuageValue)
        {
            case 0: 
            GreatText.text = "SUPERB!"; 
            PoppedText.text = "YOU POPPED:"; 
            GradeText.text = "GRADE:"; 
            ReplayText.text = "REPLAY!"; 
            break; 
            //Sets text to display "Good Job!"

            case 1: 
            GreatText.text = "SUPERBE!";
            PoppedText.text = "ÉCLATÉ:"; 
            GradeText.text = "GRADE:"; 
            ReplayText.text = "JOUER";
            break; //Sets text to display "Good Job!"

            case 2: 
            GreatText.text = "¡ESTUPENDO!"; 
            PoppedText.text = "REVENTAR:"; 
            GradeText.text = "GRADO:"; 
            ReplayText.text = "JUGAR";
            break; //Sets text to display "Good Job!"

            case 3: 
            GreatText.text = "SUPERBO!"; 
            PoppedText.text = "SCOPPIETTANTI:"; 
            GradeText.text = "GRADO:"; 
            ReplayText.text = "GIOCO";
            break; //Sets text to display "Good Job!"

            default: print("invalid langvalue in feedback text"); break;
        }
    }
}
