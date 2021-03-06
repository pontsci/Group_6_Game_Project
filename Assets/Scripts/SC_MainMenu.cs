﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Code was taken from: https://sharpcoderblog.com/blog/unity-3d-create-main-menu-with-ui-canvas
public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject ControlsMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("DevScene_Emeara");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
        ControlsMenu.SetActive(false);
    }

    public void ControlsButton()
    {
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(false);
        ControlsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        ControlsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}