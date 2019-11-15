using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderMessage : MonoBehaviour
{
	public Component ColliderDestination;
	private iColliderMessage _colliderDestination;

	//Validate when the inspector is updated
	private void OnValidate()
	{
		if ((ColliderDestination.GetComponent<iColliderMessage>()) == null)
			ColliderDestination = null;
	}

	//When the script runs, grab the interface
	private void Awake()
	{
		if (ColliderDestination != null)
			_colliderDestination = ColliderDestination.GetComponent<iColliderMessage>();
	}

	//On Trigger Enter for communication
    private void OnTriggerEnter(Collider col)
    {
    	_colliderDestination.TriggerEnter(col);
    }
}

