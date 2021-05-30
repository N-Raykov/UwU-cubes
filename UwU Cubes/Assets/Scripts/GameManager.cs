using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //bool is used for true or false statements
    public bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;

    public GameObject UwU;

    public GameObject OwO;

    public void Completelevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        //If EndGame has been called (in PlayerCollision or PlayerMovement) the if statement will return as true and will change gameHasEnded to true and the next time it is called the if statement will return as false so the game won't end multiple times
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay); //Invoke is used when calling an element and can be used with some delay
        }

        if (gameHasEnded == true)
        {
            UwU.SetActive(false);
            OwO.SetActive(true);
        }
    }
    void Restart()
    {
        //this loads the current scene (just restarts)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().Restart();
        }

    }

    public void CompleteEndless ()
    {
        SceneManager.LoadScene(14);
    }


}
