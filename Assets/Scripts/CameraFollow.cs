using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] Transform player;
	float velocity;


	void Update()
	{
		float zTarget = player.position.z;
		float yTarget = player.position.y;
		float zPos = transform.position.z;
		float yPos = transform.position.y;
		zPos = Mathf.SmoothDamp(zPos, zTarget, ref velocity, 2 * Time.deltaTime);
		yPos = Mathf.SmoothDamp(yPos, yTarget, ref velocity, 2 * Time.deltaTime);
		transform.position = new Vector3(transform.position.x, yPos, zPos);
	}
}
