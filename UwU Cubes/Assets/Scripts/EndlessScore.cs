using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EndlessScore : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            Invoke("EndEndless", FindObjectOfType<GameManager>().restartDelay - 0.1f);
        }
    }
    void EndEndless()
    {
        FindObjectOfType<Score>().ChangeColor();
        FindObjectOfType<PauseMenu>().Pause();
    }
}
