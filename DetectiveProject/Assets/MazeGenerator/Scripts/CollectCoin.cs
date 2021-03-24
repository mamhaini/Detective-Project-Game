using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    // If score counter is 10, level completed.
    public int levelComplete = 10;

    // If player collides with a coin, score goes up by 1 point
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 1;
        Destroy(gameObject);

        // Level completed means load ending scene
        if (ScoringSystem.theScore == levelComplete)
        {
            SceneManager.LoadScene(2);
        }
    }
}
