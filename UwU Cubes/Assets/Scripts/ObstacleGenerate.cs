using UnityEngine;
using UnityEngine.AI;

public class ObstacleGenerate : MonoBehaviour
{
    public float zDistance = 10;
    public float minSpread = 50;
    public float maxSpread = 100;

    public Transform playerTransform;
    public Transform obstaclePrefab;

    float zSpread;
    float lastZposition;

    void Start()
    {
        lastZposition = Mathf.NegativeInfinity;
        zSpread = Random.Range(minSpread, maxSpread);
    }

    void Update ()
    {
        if (playerTransform.position.z - lastZposition >= zSpread) 
        {
            float lanePosition = Random.Range(-7f, 6.8f);
            Instantiate(obstaclePrefab, new Vector3(lanePosition, 1, playerTransform.position.z + zDistance), Quaternion.identity);

            lastZposition = playerTransform.position.z;
            zSpread = Random.Range(minSpread, maxSpread);
        }
    }
}
