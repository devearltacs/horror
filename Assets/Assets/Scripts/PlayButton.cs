using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Button play_button, exit_button;
    
    private void Start() {
        play_button.onClick.AddListener(PlayGame);
        exit_button.onClick.AddListener(ExitGame);
    }

    void PlayGame() {
        SceneManager.LoadScene(1);
    }

    void ExitGame() {
        Application.Quit();
    }
}
