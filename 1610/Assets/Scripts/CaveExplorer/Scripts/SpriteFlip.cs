using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{

	public SpriteRenderer SpriteOne, SpriteTwo, SpriteThree, SpriteFour, SpriteFive;
	
	// Update is called once per frame
	void Update () {

		if (SpriteOne != null)
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				SpriteOne.flipX = true;
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				SpriteOne.flipX = false;
			}
		}
		
		if (SpriteTwo != null)
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				SpriteTwo.flipX = true;
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				SpriteTwo.flipX = false;
			}
		}
		
		if (SpriteThree != null)
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				SpriteThree.flipX = true;
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				SpriteThree.flipX = false;
			}
		}
		
		if (SpriteFour != null)
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				SpriteFour.flipX = true;
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				SpriteFour.flipX = false;
			}
		}
		
		if (SpriteFive != null)
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				SpriteFive.flipX = true;
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				SpriteFive.flipX = false;
			}
		}
	}
}
