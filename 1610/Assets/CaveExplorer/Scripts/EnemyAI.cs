using Boo.Lang;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

	public float Speed = 3;
	public Transform DestinationOne, DestinationTwo;
	public SpriteRenderer[] Sprites;
	
	void Update()
	{
		if (DestinationOne.gameObject.activeSelf)
		{
			transform.Translate(Vector3.left * (Speed * Time.deltaTime));
			DestinationTwo.gameObject.SetActive(true);
		}

		if (Vector3.Distance(transform.position, DestinationOne.position) < 1 || DestinationOne.gameObject.activeSelf == false)
		{
			DestinationOne.gameObject.SetActive(false);
			for (int i = 0; i < Sprites.Length; i++)
			{
				Sprites[i].flipX = true;
			}
			transform.Translate(Vector3.right * (Speed * Time.deltaTime));

			if (Vector3.Distance(transform.position, DestinationTwo.position) < 1)
			{
				DestinationOne.gameObject.SetActive(true);
				DestinationTwo.gameObject.SetActive(false);
				for (int i = 0; i < Sprites.Length; i++)
				{
					Sprites[i].flipX = false;
				}
				transform.Translate(Vector3.left * (Speed * Time.deltaTime));
			}
		}
	}
}