using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarScript : MonoBehaviour
{

	public FloatData DataOne, DataTwo, DataThree;
	public Image ImageOne, ImageTwo, ImageThree;
	
	// Use this for initialization
	void Start ()
	{
		ImageOne = GetComponent<Image>();
		ImageTwo = GetComponent<Image>();
		ImageThree = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		if (ImageOne.fillAmount >= 0.1f)
		{
			ImageOne.fillAmount = DataOne.Value;
		}

		if (ImageOne.fillAmount == 0)
		{
			ImageTwo.fillAmount = DataTwo.Value;
		}

		if (ImageTwo.fillAmount == 0)
		{
			ImageThree.fillAmount = DataThree.Value;
		}
	}
}
