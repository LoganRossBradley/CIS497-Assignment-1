/* Logan Ross
 * assignment 1
 * Gun.cs
 * sets up the gun superclass that more specific gun types will inherit from
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon, Pickup
{
    private string name;
    private int level;
    private string elementalType;
    private int magSize;
    private int reloadSpeed;
    private string attackStyle;
    private string weaponType;

    public void Shoot()
    {
        Debug.Log("You shoot your "+weaponType);
    }
    public void reload()
    {
        Debug.Log("You reload your " + weaponType);
    }
    public string getAttackStyle()
    {
        return attackStyle;
    }

    public void pickup()
    {
        Debug.Log("You picked up " + weaponType);
    }
    public void setWeaponType(string type)
    {
        weaponType = type;
    }
    public string getWeaponType()
    {
        return weaponType;
    }
}
