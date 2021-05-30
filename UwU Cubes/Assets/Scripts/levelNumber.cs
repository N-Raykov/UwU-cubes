using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelNumber : MonoBehaviour
{
    public Text LevelNumber;
    void Start()
    {
        LevelNumber.text = "level " + SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
