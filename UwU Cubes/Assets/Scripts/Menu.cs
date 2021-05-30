using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartEndless()
    {
        SceneManager.LoadScene(12);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void About()
    {
        SceneManager.LoadScene(13);
    }
}

