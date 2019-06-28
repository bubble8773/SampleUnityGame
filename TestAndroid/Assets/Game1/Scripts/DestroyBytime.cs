using UnityEngine;
using System.Collections;

public class DestroyBytime : MonoBehaviour {
	public float objLifeTime;

    
    void Start () {
        //objLifeTime = 5.0f;
        
        Destroy (gameObject, objLifeTime);
	}

    

}




