using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public GameObject door;

	public static bool isKeyCollected = false;
		
	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Door doorScript = (Door)door.GetComponent(typeof(Door));
		doorScript.Unlock();
		Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.identity);
		Object.Destroy(this.gameObject);
		isKeyCollected = true;
    }

}
