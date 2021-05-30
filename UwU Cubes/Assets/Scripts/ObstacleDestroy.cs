using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Update()
    {
        transform.position = player.position + offset;
    }

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "Obstacle")
        {
            Destroy(collisioninfo.gameObject);
        }
    }
}
