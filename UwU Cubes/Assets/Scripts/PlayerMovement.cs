using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    //public is used for variables
    //rigidbody component rb
    public Rigidbody rb;

    //float contains a single decimal numeric value
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

    //Fixed update because we are using it to mess with the physics
    void FixedUpdate() 
    {
        //Time.deltaTime is used when  you want movement or any other constant variable change, to be the same speed, no matter the framerate
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            //Only executed if condtions are met
            //ForceMode.VelocityChange is used when we want to change the velocity of an object while ignoring the current direction it is travelling
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            //Only executed if condtions are met
            //ForceMode.VelocityChange is used when we want to change the velocity of an object while ignoring the current direction it is travelling
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }    

    }
}
