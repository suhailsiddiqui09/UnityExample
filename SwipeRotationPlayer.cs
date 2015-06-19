using UnityEngine;
using System.Collections;

public class SwipeRotationPlayer : TouchLogicV2//NOTE: This script has been updated to V2 after video recording
{
	public float rotateSpeed = 100.0f;


	private float pitch = 0.0f,
	yaw = 0.0f;

	
	void OnTouchMovedAnywhere()
	{
		pitch -= Input.GetTouch(0).deltaPosition.y * rotateSpeed * Time.deltaTime;
		yaw += Input.GetTouch(0).deltaPosition.x * rotateSpeed * Time.deltaTime;

		//do the rotations of our camera
		this.transform.eulerAngles = new Vector3 ( pitch, yaw, 0.0f);
	}
}