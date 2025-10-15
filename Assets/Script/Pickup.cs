/*using UnityEngine;
using System;
public class Pickup : MonoBehaviour
{
    public static event Action OnPickupCollected;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (OnPickupCollected != null)
            {
                OnPickupCollected();
            }
            Destroy(gameObject);
        }
    }

}
*/