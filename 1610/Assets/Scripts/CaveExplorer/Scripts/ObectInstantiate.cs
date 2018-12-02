using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectInstantiate : MonoBehaviour
{

	public GameObject InstanceOne, InstanceTwo;
	public float Seconds = 2;
	public float StartDelaySeconds = 0;
	public float DelaySeconds = 0.5f;
	
	// Use this for initialization
	IEnumerator Start () {
		while (true)
		{
			yield return new WaitForSeconds(StartDelaySeconds);
			yield return new WaitForSeconds(Seconds);
			Instantiate(InstanceOne, transform.position, transform.rotation);
			yield return new WaitForSeconds(DelaySeconds);
			Instantiate(InstanceOne, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(Seconds);
			Instantiate(InstanceTwo, transform.position, transform.rotation);
		}
	}
}