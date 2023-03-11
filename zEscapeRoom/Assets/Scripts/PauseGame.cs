using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool pauseGame;

    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            if (pauseGame)
            {
                Continue();
                CursorLock();
            }
            else
            {
                Pause();
                CursorUnlock();
            }
        }
    }

    void Continue()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;
    }

    void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        pauseGame = true;
    }

    void CursorUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
