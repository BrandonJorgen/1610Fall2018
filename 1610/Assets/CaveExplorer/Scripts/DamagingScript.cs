using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamagingScript : MonoBehaviour
{

	public UnityEvent TriggerEnter;
	
	IEnumerator OnTriggerEnter(Collider other)
	{
		switch (other.gameObject.tag)
		{
				case "Player":
					TriggerEnter.Invoke();
					yield return new WaitForSeconds(0.5f);
					break;
		}
	}
	
}

