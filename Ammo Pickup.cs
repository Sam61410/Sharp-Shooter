using UnityEngine;

public class AmmoPickup : Pickup
{
    int ammoAmount = 100;
    protected override void OnPickup(ActiveWeapon activeWeapon)
    {
        activeWeapon.AdjustAmmo(ammoAmount);
    }
}
