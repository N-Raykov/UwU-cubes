using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessEnd : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteEndless();
        gameManager.enabled = false;
    }
}
