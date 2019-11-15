# Unity3D_ChildTriggerPlugin
Plugin to control communication between child and parent scripts.

# Usage (in 3 steps!)
1) Impliment the iColliderMessage interface on the script you want to have the communication to. E.g. your AIController.cs.
2) Drag the ColliderMessage.cs script onto the child component you want to check for triggers. E.g. your SoundDetectorGameObject.
3) Drag your implimented script (AIController.cs) onto the Component variable on your child (SoundDetectorGameObject)

