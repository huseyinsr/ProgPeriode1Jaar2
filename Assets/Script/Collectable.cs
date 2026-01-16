/*using System;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    public static Action Collected;

    public abstract void OnCollect();

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect();
            Destroy(gameObject);
            Collected?.Invoke();

        }
        
    }
}
*/