/* public bool IsPlayerReadyToAttack(Player player)
{
    if (player == null) return false; 
    if (!player.IsAlive) return false;
    if (player.AttackCooldown > 0) return false;
    if (player.Target == null) return false;
    if (!player.Target.IsAlive) return false;
    
    float distanceToTarget = Vector3.Distance(player.transform.position, player.Target.transform.position);


    if (distanceToTarget >= 5f) return false;

    if (palyer.IsStunned) return false;
    if (player.IsSlowed) return false;

    bool hasEnoughManaAndWeapon 
    if (player.Mana >= 20 && player.WeaponEquipped);
        hasEnoughManaAndWeapon = true;

    bool hasHealthAndBuff
    if (player.Health > 30 && player.HasBuff("Strength"));
        hasHealthAndBuff = true;

   if (!hasEnoughManaAndWeapon && !hasHealthAndBuff) return false;

   return true;

*/