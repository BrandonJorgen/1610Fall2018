using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{

	public Transform DestinationOne, DestinationTwo;
	private NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		agent.SetDestination(DestinationTwo.position);
		
		if (agent.remainingDistance <= agent.stoppingDistance)
		{
			agent.SetDestination(DestinationOne.position);
		}
	}
}
