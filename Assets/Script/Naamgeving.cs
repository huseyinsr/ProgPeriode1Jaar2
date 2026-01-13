/*using UnityEngine;

public class Naamgeving : MonoBehaviour
{ 
    private class GameManager : MonoBehaviour
    {
        private int HealthPoint;
        private float JumpPower;
        private bool IsPlayerDead;
    }
}
*/
/*using UnityEngine;
using UnityEngine.UIElements;

public class BaseEnemy : MonoBehaviour
{ 
    private int health = 100f;
    private float speed = 9f;

    virtual void TakeDamage(int damage)
    {
        health -= damage;
    }
    virtual float CalculateRange(float modifier)
    {
        return range
    }

}

public class Enemy : BaseEnemy
{
    float attackRange = 2f;
    GameObject player;
    void Attack()
    {
        // Attack logic
    }

    void Update()
    {
        if (Distance(gameObject.transform, position, player.transform.position) > CalculateRange(speed / 5)
        {
            Attack();
        }
    }
    void OnTriggerEnter(Collision other)
    {
        if (other.CompareTag("Trap"))
        {
            TakeDamage(50);
        }s
    }
     void Attack()
    {
        // Attack logic
    }

}
*/