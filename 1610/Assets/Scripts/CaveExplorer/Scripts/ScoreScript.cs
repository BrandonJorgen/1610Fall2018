using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreScript : MonoBehaviour
{

	public FloatData Value;
	public UnityEvent ScoreZero, ScoreOne, ScoreTwo, ScoreThree, ScoreFour, ScoreFive, ScoreSix;
	
	// Update is called once per frame
	void Update ()
	{
		if (Value.Value == 0)
		{
			ScoreZero.Invoke();
		}
		
		if (Value.Value == 1)
		{
			ScoreOne.Invoke();
		}
		
		if (Value.Value == 2)
		{
			ScoreTwo.Invoke();
		}
		
		if (Value.Value == 3)
		{
			ScoreThree.Invoke();
		}
		
		if (Value.Value == 4)
		{
			ScoreFour.Invoke();
		}
		
		if (Value.Value == 5)
		{
			ScoreFive.Invoke();
		}
		
		if (Value.Value == 6)
		{
			ScoreSix.Invoke();
		}
	}
}
