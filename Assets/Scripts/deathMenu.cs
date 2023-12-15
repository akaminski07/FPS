using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class deathMenu : MonoBehaviour
{
    void Start()
    {
        UnlockMouse();
    }
    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void PlayGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
