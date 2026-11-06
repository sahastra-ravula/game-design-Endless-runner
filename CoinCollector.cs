
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 10;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
