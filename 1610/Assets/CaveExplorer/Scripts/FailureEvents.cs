using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FailureEvents : MonoBehaviour
{

	public UnityEvent PlayerDeath;
	public FloatData ValueOne, ValueTwo;

	private void Update()
	{
		if (ValueOne.Value == ValueTwo.Value)
		{
			PlayerDeath.Invoke();
		}
	}
	
}
