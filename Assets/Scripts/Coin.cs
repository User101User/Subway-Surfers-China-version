using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Pr�fen, ob es eine M�nze ist
        {
            Destroy(gameObject); // M�nze zerst�ren
            Debug.Log("destroy");
            ScoreManager.score += 1;

        }
    }
}