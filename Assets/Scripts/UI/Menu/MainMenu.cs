using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
