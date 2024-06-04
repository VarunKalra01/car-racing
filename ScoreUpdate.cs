using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("ScoreText is not assigned in the inspector.");
            return;
        }

        StartCoroutine(IncreaseScoreOverTime());
    }

    IEnumerator IncreaseScoreOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            IncreaseScore(1);
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}



