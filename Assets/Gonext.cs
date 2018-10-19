using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gonext : MonoBehaviour {

    // Use this for initialization
    public bool Nextone;

    void Start () {
        Nextone = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    private void OnMouseDown()
    {
        Nextone = true;
    }
}
