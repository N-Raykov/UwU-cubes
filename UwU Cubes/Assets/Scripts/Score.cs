using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //scoreText is used for our text .text is used because the object type is text and we make it equal to the player position. To string is used to change the precision
        scoreText.text = player.position.z.ToString("0");
    }
    public void ChangeColor ()
    {
        scoreText.color = Color.red;
    }
}
