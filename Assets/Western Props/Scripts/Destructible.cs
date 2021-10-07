// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

	public GameObject destroyedVersion; // Reference to the shattered version of the object
	public GameObject gem;

	public GameObject parent;

	public Vector3[] offset;

	// If the player clicks on the object
	//void OnMouseDown ()
	//{
	//	// Spawn a shattered object
	//	Instantiate(destroyedVersion, transform.position, transform.rotation);
	//	// Remove the current object
	//	Destroy(gameObject);
	//}
	void start()
    {
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			// Remove the current object
			Destroy(gameObject);
			FindObjectOfType<AudioManager>().Play("WoodenBox");
			for (int i = 0; i < 4; i++)
			{
				//transform.position + offset[i]
				Instantiate(gem, transform.GetChild(i).gameObject.transform.position, transform.rotation);
				Debug.Log(offset[i]);
			}
			
			
			// Spawn a shattered object
			Instantiate(destroyedVersion, transform.position, transform.rotation);
		}
	}

	void update()
    {
    }

}
