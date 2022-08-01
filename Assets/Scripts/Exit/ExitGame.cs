using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    
    public void QuitGame()
    {
        Debug.Log("O jogo foi fechado");
        Application.Quit();
    }
}
