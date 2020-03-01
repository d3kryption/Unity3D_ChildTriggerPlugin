using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExitMessage : MonoBehaviour
{
    public delegate void ColliderActivate(Collider col);
	
    public ColliderActivate ColliderActivated;
	public Component TriggerExitDestination;
	private iTriggerExit _triggerExit;

	//Validate when the inspector is updated
	private void OnValidate()
	{
		if (TriggerExitDestination == null || (TriggerExitDestination.GetComponent<iTriggerExit>()) == null)
			TriggerExitDestination = null;
	}

	//When the script runs, grab the interface
	private void Awake()
	{
		if (TriggerExitDestination != null)
			_triggerExit = TriggerExitDestination.GetComponent<iTriggerExit>();
	}

	//On Trigger Exit for communication
    private void OnTriggerExit(Collider col)
    {
		if (ColliderActivated != null)
			ColliderActivated(col);

    	_triggerExit.TriggerExit(col);
    }
}

