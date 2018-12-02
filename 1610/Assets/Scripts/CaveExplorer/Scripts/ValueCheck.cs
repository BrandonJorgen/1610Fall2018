using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ValueCheck : MonoBehaviour
{

	public UnityEvent OnStart, EDown, HealthIncrease, AfterEvent, ShowZero, ShowOne, ShowTwo, ShowThree, ShowFour, ShowFive;
	public FloatData Value;
	public Image Image;

	void Start()
	{
		OnStart.Invoke();
	}

	// Update is called once per frame
	void Update () {
		
		if (Value.Value == 5)
		{
			ShowFive.Invoke();
		}

		if (Value.Value == 4)
		{
			ShowFour.Invoke();
		}

		if (Value.Value == 3)
		{
			ShowThree.Invoke();
		}

		if (Value.Value == 2)
		{
			ShowTwo.Invoke();
		}

		if (Value.Value == 1)
		{
			ShowOne.Invoke();
		}

		if (Value.Value == 0)
		{
			ShowZero.Invoke();
		}
		
		if (Input.GetKeyDown(KeyCode.E))
		{

			if (Value.Value >= 1 && Image.fillAmount == 1)
			{
				
			}
			
			if ((Value.Value <= 5 && Value.Value > 0) && Image.fillAmount < 1)
			{
				HealthIncrease.Invoke();
				EDown.Invoke();
			}
		}
	}
}