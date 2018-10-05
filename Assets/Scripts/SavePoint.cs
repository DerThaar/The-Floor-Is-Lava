using UnityEngine;

public class SavePoint : MonoBehaviour
{	
	[SerializeField] Reset reset;


	private void OnTriggerEnter(Collider other)
	{
		reset.startPosition = transform.position;
		Destroy(gameObject);
	}
}
