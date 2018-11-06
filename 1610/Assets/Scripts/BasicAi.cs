using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{

	public Transform Destination;
	public Transform FinalDestination;
	private NavMeshAgent agent;
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
	{
		if (Destination != null)
		{
			agent.destination = Destination.position;
		}
		else
		{
			agent.destination = FinalDestination.position;
		}
	}
}
