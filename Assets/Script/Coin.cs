/*using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action OnCoinDestroyed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCoinDestroyed?.Invoke();
            Destroy(gameObject);
        }
    }
}
*/