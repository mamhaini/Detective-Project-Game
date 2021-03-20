using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    public int levelComplete = 10;
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 1;
        Destroy(gameObject);

        if (ScoringSystem.theScore == levelComplete)
        {
            SceneManager.LoadScene(2);
        }
    }
}
