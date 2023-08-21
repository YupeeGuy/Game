using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void StartTheGame()
    {
        SceneManager.LoadScene("Home");
    }
    public void EndTheGame()
    {
        Application.Quit();
    }
}
