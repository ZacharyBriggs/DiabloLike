using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private NavMeshAgent PlayerAgent;
	void Start ()
    {
        PlayerAgent = GetComponent<NavMeshAgent>();
	}

	void Update ()
    {
		if(Input.GetButtonDown("Fire2"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit,1000))
            {
                PlayerAgent.SetDestination(hit.point);
            }
        }
	}
}
