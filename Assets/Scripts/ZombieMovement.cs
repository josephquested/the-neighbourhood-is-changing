using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	NavMeshAgent agent;

	public Transform target;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update ()
	{
		target = GameObject.FindWithTag("Player").transform;
		if (target)
		{
			agent.destination = target.position;
		}
	}
}
