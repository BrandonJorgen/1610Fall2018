using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public CharacterController Character;
	public float Speed;
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	
	// Update is called once per frame
	void Update ()
	{
		MoveSpeed.x = Speed * Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
	}
}
