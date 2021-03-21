/* Logan Ross
 * assignment 1
 * ConsoleOutput.cs
 * manages log statments for buttion presses
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleOutput : MonoBehaviour
{
    public Gun currentWeapon;

    public void pickupClick()
    {
        int num = Random.Range(0, 2);
        if(Random.Range(0, 2) == 1)
        {
            currentWeapon = new SMG();
        }
        else
        {
            currentWeapon = new Shotgun();
        }
        currentWeapon.pickup();
    }

    public void shootClick()
    {
        currentWeapon.Shoot();
    }

    public void reloadClick()
    {
        currentWeapon.reload();
    }

}
