using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowMouse : MonoBehaviour
{
    public Button exit_button;
    void Start()
    {
        exit_button.onClick.AddListener(ExitGame);
        
        StartCoroutine(WaitBeforeShowingCursor());
    }

    IEnumerator WaitBeforeShowingCursor() {
        yield return new WaitForSeconds(2);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void ExitGame() {
        SceneManager.LoadScene(0);
    }
}
