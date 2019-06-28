using UnityEngine;
using System.Collections;

public class MovementTry : MonoBehaviour {
	RaycastHit rayCastHit;
	private float rayDist = 10000; 
	

	void FixedUpdate () {

		GameObject Player = GameObject.Find ("Player");//"OldSingleCut");//
		//Ray camRay = Camera.main.ScreenPointToRay (AndroidInput.GetSecondaryTouch (0).position);//(Input.mousePosition);
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Physics.Raycast(camRay, out  rayCastHit,  rayDist) ) 
		   {
				//Debug.Log(rayCastHit.collider.name );
				 if(rayCastHit.collider.name == "Plane"){
			         Player.transform.position = rayCastHit.point;
				}
		}

		Debug.DrawRay (camRay.origin, camRay.direction * rayDist, Color.cyan);

	}
}
