using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemSwitch : MonoBehaviour
{

	public Inventory.InventoryItems CurrentItem;
	public UnityEvent Nothing, Potion;
	
	// Update is called once per frame
	void Update () {
		switch (CurrentItem)
		{
				case Inventory.InventoryItems.Nothing:
					print("You currently have Nothing Selected");
					break;
			
				case Inventory.InventoryItems.Potion:
					print("You currently have a Potion Selected");
					break;
		}
	}
}
