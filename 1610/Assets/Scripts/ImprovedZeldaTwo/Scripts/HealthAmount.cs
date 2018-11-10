using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAmount
{

	public enum HealthUnits
	{
		Default,
		ContainerOne,
		ContainerTwo,
		ContainerThree,
		ContainerFour,
		ContainerFive
	}

	public HealthUnits Limit;
}
