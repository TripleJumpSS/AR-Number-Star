using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScreenLang : MonoBehaviour
{
    public int LanuageValue;
    public TMP_Text GreatText;
    public TMP_Text PoppedText;
    public TMP_Text GradeText;
    public TMP_Text ReplayText;
    public GameObject GameManager;
    void Awake()
    {
        LanuageValue = GameManager.GetComponent<GameManager>().LanuageValue;
        switch (LanuageValue)
        {
            case 0: 
            GreatText.text = "SUPERB!"; 
            PoppedText.text = "YOU POPPED:"; 
            GradeText.text = "GRADE:"; 
            ReplayText.text = "SUPERB!"; 
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
