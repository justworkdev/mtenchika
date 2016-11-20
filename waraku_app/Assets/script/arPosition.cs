using UnityEngine;
using System.Collections;

public class arPosition : MonoBehaviour {

	GameObject cam;
	GameObject ar_char;


	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Camera");
		ar_char = GameObject.Find ("myojowaraku2016_logo");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (cam.transform.position.x + ":" + cam.transform.position.y + ":" + cam.transform.position.z + ":");
		Vector3 target = new Vector3(ar_char.transform.position.x, cam.transform.position.y + 180.0f , cam.transform.position.z + 180);
		ar_char.transform.LookAt(target);
	}
}
