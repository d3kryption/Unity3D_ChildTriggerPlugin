# Unity3D_ChildTriggerPlugin
Plugin to control collider communication between child and parent scripts.

# Scripts
`iTriggerEnter.cs`
`iTriggerExit.cs`
`TriggerEnterMessage.cs`
`TriggerExitMessage.cs`

# Usage (in 3 steps!)
1) Impliment any collider interfaces you need on the scipt that you require. (iTriggerEnter or iTriggerExit)
```
public class AIController : MonoBehaviour, iTriggerEnter
{
	public void TriggerEnter(Collider col)
	{
    	Debug.Log(col);
	}
}
public class AIController : MonoBehaviour, iTriggerExit
{
    public void TriggerExit(Collider col)
	{
    	Debug.Log(col);
	}
}
public class AIController : MonoBehaviour, iTriggerEnter, iTriggerExit
{
	public void TriggerEnter(Collider col)
	{
    	Debug.Log(col);
	}

    public void TriggerExit(Collider col)
	{
    	Debug.Log(col);
	}
}
```

2) Drag the corresponding Trigger[TYPE]Message.cs script onto the child component you want to check for collider. E.g. your SoundDetectorGameObject.

3) Drag your implimented script (AIController.cs) onto the Component variable on your child (SoundDetectorGameObject)

