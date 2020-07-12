using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject PauseMenuButtons;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject PlayerInput;
    [SerializeField] GameObject GameResultScreen;
    [SerializeField] TextMeshProUGUI resultText;

    private void ReloadCurrentScene()
    {
        LoadingScreen.instance.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OpenMenu()
    {
        LoadingScreen.instance.LoadScene("MainMenu");
    }

    public void PressPauseButtonEvent()
    {
        PauseMenuButtons.SetActive(true);
        PauseButton.SetActive(false);
        PlayerInput.SetActive(false);
    }

    public void PressContinueButtonEvent()
    {
        PauseMenuButtons.SetActive(false);
        PauseButton.SetActive(true);
        PlayerInput.SetActive(true);
    }

    public void PressRestartButtonEvent()
    {
        ReloadCurrentScene();
    }

    public void PressOpenMenuButton()
    {
        OpenMenu();
    }

    public void OpenEndGameResult(string _res)
    {
        PauseMenuButtons.SetActive(false);
        PauseButton.SetActive(false);
        PlayerInput.SetActive(false);
        GameResultScreen.SetActive(true);
        resultText.text = _res;
        Debug.Log($"res = {_res}");
    }
}
