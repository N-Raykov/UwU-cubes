using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Transform refers to the "Transform" (position)
    public Transform player;
    //Vector3 is similar to float but contains 3 values
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //When using transform without a capital letter we are reffering to the current object
        transform.position = player.position + offset;
    }

}
