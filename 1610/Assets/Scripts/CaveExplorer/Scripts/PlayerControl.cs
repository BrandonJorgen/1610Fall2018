using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
	private CharacterController controller;
	public UnityEvent Moving, NotMoving, AttackDown, AttackUp;
	public float Gravity = 9.81f;
	public float JumpSpeed = 3.0f;
	public float MoveSpeed = 3.0f;
	private Vector3 position;
	private Vector3 rotation;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (controller.isGrounded)
		{

			position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, 0);
			position = transform.TransformDirection(position);

			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}

		position.y -= Gravity * Time.deltaTime;
		controller.Move(position * Time.deltaTime);

		//Generic Attack
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			AttackDown.Invoke();
			Debug.Log("You are Pressing the Attack Button");
			StartCoroutine(delayedEvent());
		}
		
		//Movement events
		if (Input.GetAxis("Horizontal") > 0 ||(Input.GetAxis("Horizontal") < 0))
		{
			Moving.Invoke();
		}
		else
		{
			NotMoving.Invoke();
		}
		//USE WHISKEY EVENT HERE
		//Gonna need a floatdata
		//On press, -1 to floatdata
		//display number using art assets
	}

	IEnumerator delayedEvent()
	{
		yield return new WaitForSeconds(0.25f);
		AttackUp.Invoke();
	}
}
