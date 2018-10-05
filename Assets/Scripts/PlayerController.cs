using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float magnitude = 10f;
	[SerializeField] float xAngle = 10f;
	Rigidbody rb;
	Vector3 eulerAngleVelocity;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.centerOfMass -= new Vector3(0, 1, 0);
	}

	private void FixedUpdate()
	{
		if (Input.GetButtonDown("Jump"))
		{
			rb.AddRelativeForce(Vector3.up * magnitude, ForceMode.Acceleration);
		}

		rb.MoveRotation(rb.rotation * Quaternion.Euler(xAngle * Input.GetAxis("Horizontal") + Time.fixedDeltaTime, 0f, 0f));
	}
}
