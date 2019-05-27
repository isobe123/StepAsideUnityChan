using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRemover : MonoBehaviour {

	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		
		this.unitychan = GameObject.Find ("unitychan");

	}
	
	// Update is called once per frame
	void Update () {
		
		if (this.unitychan.transform.position.z-7 > this.gameObject.transform.position.z) {
			Destroy (this.gameObject);
		}
		
	}
}
