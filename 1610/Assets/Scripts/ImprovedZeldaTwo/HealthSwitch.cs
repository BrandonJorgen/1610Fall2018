using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSwitch : MonoBehaviour
{

	public HealthAmount.HealthUnits CurrentHealthCap;
	public UnityEvent Default, ContainerOne, ContainerTwo, ContainerThree, ContainerFour, ContainerFive;
	
	// Update is called once per frame
	void Update () {
		switch (CurrentHealthCap)
		{
			case HealthAmount.HealthUnits.Default:
				print("Your max health is 3");
				break;
			
			case HealthAmount.HealthUnits.ContainerOne:
				print("Your max health is 4");
				break;
			
			case HealthAmount.HealthUnits.ContainerTwo:
				print("Your max health is 5");
				break;
			
			case HealthAmount.HealthUnits.ContainerThree:
				print("Your max health is 6");
				break;
			
			case HealthAmount.HealthUnits.ContainerFour:
				print("Your max health is 7");
				break;
			
			case HealthAmount.HealthUnits.ContainerFive:
				print("Your max health is 8");
				break;
		}
	}
}
