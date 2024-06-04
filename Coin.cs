using UnityEngine;

public class Coin : MonoBehaviour
{
    private ScoreScript scoreScript;

    void Start()
    {
        // Find the ScoreScript in the scene
        scoreScript = GameObject.FindObjectOfType<ScoreScript>();
        if (scoreScript == null)
        {
            Debug.LogError("ScoreScript not found in the scene.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Increase the score by 10
            scoreScript.IncreaseScore(10);
            
            // Destroy the coin
            Destroy(gameObject);
        }
    }
}



