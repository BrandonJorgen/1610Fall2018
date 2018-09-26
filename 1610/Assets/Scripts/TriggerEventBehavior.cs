using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{

	public UnityEvent Enable;
	public UnityEvent Trigger;
	
	private void OnEnable()
	{
		Enable.Invoke();
	}

	private void OnTriggerEnter()
	{
		Trigger.Invoke();
	}
}
