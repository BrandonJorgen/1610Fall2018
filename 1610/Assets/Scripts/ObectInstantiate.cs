using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObectInstantiate : MonoBehaviour
{

	public GameObject Instance;
	public float Seconds = 2;
	public float StartDelaySeconds = 0;
	private int i = 0;
	
	// Use this for initialization
	IEnumerator Start () {
		while (true)
		{
			yield return new WaitForSeconds(StartDelaySeconds);
			yield return new WaitForSeconds(Seconds);
			
			Instantiate(Instance, transform.position, transform.rotation);
		}
	}
}