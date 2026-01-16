/*using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    public int collectableCount = 0;
    private void Start()
    {
        FindAnyObjectByType<Collectable>();
        Collectable.Collected += OnCollectableCollected;
        collectableCount = FindObjectsByType<Collectable>(FindObjectsSortMode.None).Length;
        Debug.Log($"There are {collectableCount} collectables in the scene.");
    }

    private void OnCollectableCollected()
    {
        collectableCount--;
        Debug.Log($"Collectables remaining: {collectableCount}");
    }
}
*/

