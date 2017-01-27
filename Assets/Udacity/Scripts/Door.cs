using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update()
	public bool locked = true;
	private float initialPosition;
	public AudioClip doorLockedSound;
	public AudioClip doorUnlockSound;

	void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
		if (!locked && ((transform.localPosition.y - initialPosition) < transform.localScale.y)) {
			transform.Translate(0, 0.1f,0, Space.World);
		}
    }

	public void CheckForKey() {
		AudioSource audio = GetComponent<AudioSource>();
		if (Key.isKeyCollected) {
			locked = false;
			audio.PlayOneShot(doorUnlockSound);
		} else {
			audio.PlayOneShot (doorLockedSound);
		}
	}

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		initialPosition = transform.localPosition.y;
		locked = true;
    }
}
