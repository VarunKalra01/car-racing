using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    public GameObject obstaclePrefab;
    public GameObject pickupPrefab;

    // Offset and rotation for the pickup prefab
    public Vector3 pickupOffset;
    public Vector3 pickupRotation;

    void Start(){
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnZone(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObsticle() {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Instantiate the obstacle without offset
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

        for (int i = 2; i < 5; i++) {
            if (obstacleSpawnIndex != i && Random.Range(0, 10) < 1) {
                spawnPoint = transform.GetChild(i).transform;

                // Instantiate the pickup with offset and rotation
                Vector3 pickupPosition = spawnPoint.position + pickupOffset;
                Quaternion pickupQuaternion = Quaternion.Euler(pickupRotation);
                Instantiate(pickupPrefab, pickupPosition, pickupQuaternion, transform);
            }
        }
    }
}


