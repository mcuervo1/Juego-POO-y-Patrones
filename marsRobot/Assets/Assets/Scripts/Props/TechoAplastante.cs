using UnityEngine;
using System.Collections;

public class TechoAplastante : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collision other)
    { 
        if(other.gameObject.tag == "Player")
        {
            startFalling();
        }
    }

    private void startFalling()
    {
        throw new System.NotImplementedException();
    }
}
