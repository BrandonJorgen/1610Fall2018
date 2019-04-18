using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectRotate : MonoBehaviour
{

	public SpriteRenderer Sprite;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Sprite.flipX)
		{
			Debug.Log("I have found flipX to be true");
			transform.Rotate(0, 180, 0);

			if (Sprite.flipX == false)
			{
				Debug.Log("I have found flipX to be false");
				transform.Rotate(0, 0, 0);
			}
		}
	}
}
