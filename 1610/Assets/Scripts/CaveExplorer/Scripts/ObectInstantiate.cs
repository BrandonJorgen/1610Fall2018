using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectInstantiate : MonoBehaviour
{

	public GameObject InstanceOne, InstanceTwo;
	public float SecondsOne = 2, SecondsTwo = 0;
	public float DelaySeconds = 0.5f;
	
	// Use this for initialization
	IEnumerator Start () {
		while (true)
		{
			yield return new WaitForSeconds(SecondsOne); //Time before first obj
			Instantiate(InstanceOne, transform.position, transform.rotation);
			yield return new WaitForSeconds(DelaySeconds); //Time before sending the same obj again
			Instantiate(InstanceOne, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(SecondsTwo); //Time before sending second obj
			Instantiate(InstanceTwo, transform.position, transform.rotation);
		}
	}
}