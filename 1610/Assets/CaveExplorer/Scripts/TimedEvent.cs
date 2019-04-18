using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimedEvent : MonoBehaviour
{

	public UnityEvent OnStart, HalfHp, UpdatingEvent;
	public float SecondsOne, SecondsTwo;
	public FloatData Value;
	private Image image;
	private int loopValue = 0;
	
	void Start ()
	{
		image = GetComponent<Image>();
		OnStart.Invoke();
		StartCoroutine(lowHealthCheck());
	}

	private void Update()
	{
		if (loopValue == 1)
		{
			loopValue = 0;
			StartCoroutine(lowHealthCheck());
		}
	}

	IEnumerator lowHealthCheck()
	{
		while (image.fillAmount < Value.Value)
		{
			HalfHp.Invoke();
			yield return new WaitForSeconds(SecondsOne);
			UpdatingEvent.Invoke();
			yield return new WaitForSeconds(SecondsTwo);
		}
		loopValue += 1;
	}
}