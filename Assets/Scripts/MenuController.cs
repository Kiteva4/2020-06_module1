using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        None,
        Main,
        Settings,
        Levels,
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    public CanvasGroup levelsScreen;

    void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
        Utility.SetCanvasGroupEnabled(levelsScreen, screen == Screen.Levels);
    }

    void Awake()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void StartNewGame()
    {
        
        StarLevel_1();
    }

    public void OpenSettings()
    {
        SetCurrentScreen(Screen.Settings);
    }

    public void CloseSettings()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void OpenLevelsMenu()
    {
        SetCurrentScreen(Screen.Levels);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StarLevel_1()
    {
        SetCurrentScreen(Screen.None);
        LoadingScreen.instance.LoadScene("SampleScene");
    }

    public void StarLevel_2()
    {
        SetCurrentScreen(Screen.None);
        LoadingScreen.instance.LoadScene("SampleNewLevelScene");
    }
}
