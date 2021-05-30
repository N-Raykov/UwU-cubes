using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    //OnCollisionEnter is used when using Unity's collision function.
   void OnCollisionEnter (Collision collisionInfo)

    {
        //Entering the name of the OnCollisionEnter command and collider gives info on the game object with wich the current object has collided
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //Disables Player movement
            FindObjectOfType<GameManager>().EndGame(); //FindObjectOfType is used when searching for a script, it is similar to GetComponent from object  
        }
    }
    
}
