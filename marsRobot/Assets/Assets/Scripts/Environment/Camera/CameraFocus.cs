using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {

    public Vector3 offSet;
    public Transform target;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position + offSet;
	}

    // Will be used to enable the camera for every plane

    public enum Plane { 
        xy, xz, yz
    }
}
