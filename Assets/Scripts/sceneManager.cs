using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void RestartGame() //Restarts game when you press the Replay button on the win screen.
    {
        SceneManager.LoadScene("BalloonLevel");
    }
}
