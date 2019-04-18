using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class BasicAi : MonoBehaviour
{

	public Transform DestinationOne;
	public UnityEvent ReachedDestination;
	private NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		agent.SetDestination(DestinationOne.position);

		if (transform.position.x == DestinationOne.position.x)
		{
			ReachedDestination.Invoke();
		}
	}
}
