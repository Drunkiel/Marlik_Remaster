using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public OpenCloseUI _uiController;
    private bool isTimeFrozen;

    void Update()
    {
        OpenPauseMenu();
    }

    public void OpenPauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _uiController.OpenClose();
            TimeManager();
        }
    }

    public void ResumeButton()
    {
        _uiController.OpenClose();
        TimeManager();
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    void TimeManager()
    {
        isTimeFrozen = !isTimeFrozen;

        if(!isTimeFrozen) Time.timeScale = 1.0f;
        else Time.timeScale = 0.0f;
    }
}
