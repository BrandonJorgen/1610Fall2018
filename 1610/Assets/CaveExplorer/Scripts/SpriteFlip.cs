using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{

	public SpriteRenderer[] Sprite;
	
	void Update () {
		foreach (SpriteRenderer S in Sprite)
         		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				for (int i = 0; i < Sprite.Length; i++)
				{
					Sprite[i].flipX = true;
				}
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				for (int i = 0; i < Sprite.Length; i++)
				{
					Sprite[i].flipX = false;
				}
			}
		}
	}
}
