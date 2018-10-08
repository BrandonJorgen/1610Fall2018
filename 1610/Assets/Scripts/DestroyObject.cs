using System.Collections;
using UnityEngine;

public class DestroyObject : MonoBehaviour {
	
	private IEnumerator Start()
	{
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
