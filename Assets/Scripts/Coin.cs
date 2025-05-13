using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Prüfen, ob es eine Münze ist
        {
            Destroy(gameObject); // Münze zerstören
            Debug.Log("destroy");
            ScoreManager.score += 1;

        }
    }
}