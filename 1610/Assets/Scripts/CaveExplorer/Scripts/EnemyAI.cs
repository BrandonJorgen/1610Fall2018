using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

	public float Speed = 3;
	public Vector3 DestinationOne, DestinationTwo;
	private Vector3 leftMovement, rightMovement;
	
	// Use this for initialization
	void Start ()
	{
		
	}

	void Update()
	{
		transform.Translate(Vector3.left);

		if (Vector3.Distance(transform.position, DestinationOne) < 1)
		{
			transform.Translate(0, 0, 0);
		}
	}
}
