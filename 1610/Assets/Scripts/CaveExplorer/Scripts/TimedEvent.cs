using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimedEvent : MonoBehaviour
{

	public UnityEvent OnStart, HalfHp, UpdatingEvent;
	public float SecondsOne, SecondsTwo;
	private Image image;
	private IEnumerator timer;
	
	// Use this for initialization
	void Start ()
	{
		image = GetComponent<Image>();
		OnStart.Invoke();
	}
}
