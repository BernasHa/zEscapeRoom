using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject StartMenu;
    public AudioSource inGameSound;
    public AudioSource menuSound;

    public void StartAndLockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inGameSound.Play();
        Destroy(menuSound);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
