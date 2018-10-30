using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponSwitch : MonoBehaviour
{

	public WeaponList.Weapons CurrentWeapon;
	public UnityEvent Sword, LightingRod, FireRod;
	
	// Update is called once per frame
	void Update () {
		switch (CurrentWeapon)
		{
			case WeaponList.Weapons.Sword:
				print("Your current weapon is the Sword");
				break;
			
			case WeaponList.Weapons.LightingRod:
				print("Your current weapon is the Lightning Rod");
				break;
			
			case WeaponList.Weapons.FireRod:
				print("Your current weapon is the Fire Rod");
				break;
		}
	}
}
