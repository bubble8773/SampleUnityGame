using UnityEngine;
using System.Collections;

public class moveforward : MonoBehaviour {

    // Use this for initialization
    //public int dir;
    public float movementSpeed = 0.0f;
    GameObject playerObj;

	void Start () {
        playerObj = GameObject.FindWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(playerObj.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
        //transform.Translate(Vector3.forward * 5.0f *dir);
	}
}
