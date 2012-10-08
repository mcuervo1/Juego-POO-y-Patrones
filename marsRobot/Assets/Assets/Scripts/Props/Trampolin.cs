using UnityEngine;
using System.Collections;

public class Trampolin : MonoBehaviour {
    private double elapsedTime = 0.0d;
    public double reactionTime, strenght;
    private Rigidbody pusher;
	
	// Update is called once per frame
	void Update () 
    {
        if (pusher != null) 
        {
            if (elapsedTime > reactionTime)
            {
                ThrowPusher();
            }
            else 
            {
                elapsedTime += Time.deltaTime;
            }
        }
	}

    private void ThrowPusher()
    {
        pusher.AddForce(new Vector3(0.0f, (float)strenght, 0.0f), ForceMode.Impulse);
        elapsedTime = 0.0d;
    }

    void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "Player") 
        {
            pusher = other.rigidbody;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            pusher = null;
        }
    }
}
