using UnityEngine;

public class Reset : MonoBehaviour
{
	[SerializeField] Transform player;
	public Vector3 startPosition;
	Quaternion startRotation;

	void Start()
	{
		startPosition = player.position;
		startRotation = player.rotation;
	}


	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.transform.position = startPosition;
		other.gameObject.transform.rotation = startRotation;
		other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
		other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
	}
}
