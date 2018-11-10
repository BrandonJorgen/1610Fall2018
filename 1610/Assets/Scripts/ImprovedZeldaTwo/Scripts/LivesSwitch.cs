using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LivesSwitch : MonoBehaviour
{

	public PlayerLives.NumberOfLives LivesLeft;
	public UnityEvent Three, Two, One, Zero;
	
	// Update is called once per frame
	void Update () {
		switch (LivesLeft)
		{
				case PlayerLives.NumberOfLives.Three:
					print("You have Three lives left");
					break;
				
				case PlayerLives.NumberOfLives.Two:
					print("You have Two lives left");
					break;
				
				case PlayerLives.NumberOfLives.One:
					print("You have One lives left");
					break;
				
				case PlayerLives.NumberOfLives.Zero:
					print("You have Zero lives left");
					break;
				
		}
	}
}
