using UnityEngine;

public class Vampire : Enemy
{
    private float lifeStealAmount = 0.5f; 
    void Start()
    {
        gameObject.name = "Vampire";
        health = 300;

    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        float healAmount = 20f * lifeStealAmount;
        health += healAmount;
        Debug.Log($"Vampire bijt {target.name} en steelt {healAmount} health!");

    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        Debug.Log($"Vampire voelt pijn van {damage} damage!");
    }


}
