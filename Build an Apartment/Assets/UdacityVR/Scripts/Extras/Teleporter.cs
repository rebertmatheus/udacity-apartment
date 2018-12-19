using UnityEngine;
using System.Collections;

/// <summary>
/// The Teleporter class moves the player between a predetermined set of waypoints whenever the Cardboard button is pressed (or the screen touched).
/// </summary>
public class Teleporter : MonoBehaviour
{
	[Tooltip ("How tall is the player, in meters?")]
	public float height = 1.75f;
	[Tooltip ("How fast to move to new location?")]
	public float speed = 10.0f;
	[SerializeField]
	private GameObject cameraRig;
	// Reference to the camera rig representing the player
	public void MoveToWaypoint()
	{
		Vector3 destPos = new Vector3(transform.position.x, 1.65f, transform.position.z);
		//cameraRig.transform.position = Vector3.Lerp(cameraRig.transform.position, destPos, Time.deltaTime * speed);
		cameraRig.transform.position = destPos;
	}
}
