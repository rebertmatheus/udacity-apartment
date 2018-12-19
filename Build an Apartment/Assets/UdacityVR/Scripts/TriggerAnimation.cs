using UnityEngine;
using System.Collections;

/// <summary>
/// The TriggerAnimation class activates a transition whenever the Cardboard button is pressed (or the screen touched).
/// </summary>
public class TriggerAnimation : MonoBehaviour
{
	[Tooltip ("The Animator component on this gameobject")]
	public Animator animator;
	[Tooltip ("The name of the Animator trigger parameter")]
	public string triggerName = "Globe";

	private bool _isActive = false;

	public void StartGlobeAnimation()
	{
		_isActive = !_isActive;
		animator.SetBool(triggerName, _isActive);
	}
}
