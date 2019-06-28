using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	public Text scoreText;
    public GameObject popUp;
	int score;
	public float timer;
    

	// Use this for initialization
	void Start () {
		score = 0;
		timer = 0.0f;
  
    }

    // Update is called once per frame
    void Update () {
        
        if (popUp.activeInHierarchy)
            Time.timeScale = 0.0f;
        else
        { Time.timeScale = 1.0f;
            timer = Time.deltaTime * 0.01f;
            if (timer > 0)
            {
                score += 1;
                scoreText.text = "Score: " + score;
            }
        }
       

	}
}
