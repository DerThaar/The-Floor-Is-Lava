using UnityEngine;

public class Explosion : MonoBehaviour
{
	public float explosionRadius = 3f;
	[SerializeField] float explosionForce = 20f;
	[SerializeField] Transform player;


	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.transform == player)
		{
			Explode();
		}
	}

	void Explode()
	{
		player.gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, explosionRadius, 0, ForceMode.Impulse);
	}
}
