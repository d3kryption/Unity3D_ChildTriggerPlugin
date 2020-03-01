using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterMessage : MonoBehaviour
{
    public delegate void ColliderActivate(Collider col);
	
    public ColliderActivate ColliderActivated;
	public Component TriggerEnterDestination;
	private iTriggerEnter _triggerEnter;

	//Validate when the inspector is updated
	private void OnValidate()
	{
		if (TriggerEnterDestination == null || (TriggerEnterDestination.GetComponent<iTriggerEnter>()) == null)
			TriggerEnterDestination = null;
	}

	//When the script runs, grab the interface
	private void Awake()
	{
		if (TriggerEnterDestination != null)
			_triggerEnter = TriggerEnterDestination.GetComponent<iTriggerEnter>();
	}

	//On Trigger Enter for communication
    private void OnTriggerEnter(Collider col)
    {
		if (ColliderActivated != null)
			ColliderActivated(col);

    	_triggerEnter.TriggerEnter(col);
    }
}

