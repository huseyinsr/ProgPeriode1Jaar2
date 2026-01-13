/*using UnityEngine;
using UnityEngine.Audio;

public class EnemyLes5 : MonoBehaviour
{
    protected float speed = 2f;
    private Health myHealth;
    void Start()
    {

    }

    public void Awake()
    {
        myHealth = GetComponent<Health>();
        if (GetComponent<Collider>() == null)
        {
            gameObject.AddComponent<BoxCollider>();
        }
    }
    public void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void TakeDamage(int amount)
    {
        myHealth.TakeDamage(amount);
    }
}*/