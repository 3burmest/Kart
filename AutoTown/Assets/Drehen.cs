using UnityEngine;
using System.Collections;

public class Drehen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	   transform.Rotate(new Vector3(0, 0.3F, 0));
	}
}
