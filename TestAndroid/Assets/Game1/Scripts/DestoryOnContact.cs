using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class DestoryOnContact : MonoBehaviour {

    public GameObject gameOverPopUp;
	//PlayAgain playGameAgain;
	void OnTriggerEnter(Collider other)	{
		Debug.Log (other.transform.name);
		
		if(other.GetComponent<Collider> ().tag == "Enemy"){
            //GameOverLevel ();
            gameOverPopUp.SetActive(true);
        }

	}


    //void GameOverLevel()
    //{


    //    Application.LoadLevel("GameOver");
    //}


}