using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScena : MonoBehaviour
{

    public Button Botao;
    private string SCN_Pong;

    void Start()
    {
        SCN_Pong = SceneManager.GetActiveScene().name;
        Botao.onClick = new Button.ButtonClickedEvent();
        Botao.onClick.AddListener(() => CarregarCena());
    }

    void CarregarCena()
    {
        SceneManager.LoadScene(SCN_Pong);
    }
}