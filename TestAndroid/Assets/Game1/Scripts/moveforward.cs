using UnityEngine;
using System.Collections;

public class moveforward : MonoBehaviour {

    // Use this for initialization
    public int dir;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 5.0f *dir);
	}
}
