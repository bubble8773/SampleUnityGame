using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class coinPickup : MonoBehaviour {

	public Text coinText;
	int coins;
    int unlockedLevelIndex;
    public Text levelName;

    public GameObject gameWinPopUP;
   
    void Start () {
		//Cursor.visible = false;
		coins = 0;
        levelName.text = "Level: " + PlayerPrefs.GetInt("SelectedLevel");
        PlayerPrefs.SetInt("LevelComplete", 0);
    }

    //Destory coins and update to the score board
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        if (other.GetComponent<Collider>().tag == "Diamond")//"Coin") 
        {
            Destroy(other.gameObject);
            coins += 1;

        }

        //levelcomplete condition
        if (coins == 10)
        {
            PlayerPrefs.SetInt("LevelComplete", 1);
            // unlock the next level
            unlockedLevelIndex = PlayerPrefs.GetInt("SelectedLevel") + 1;
            PlayerPrefs.SetInt("UnlockedLevel", unlockedLevelIndex);

            Debug.Log(PlayerPrefs.GetInt("UnlockLevel"));
            //Application.LoadLevel(5);//gamewin
            gameWinPopUP.SetActive(true);
            if (gameWinPopUP.activeInHierarchy)
                Time.timeScale = 0.01f;
            else
                Time.timeScale = 1.0f;


        }
    }

    void Update()
	{        
        coinText.text = "Rewards: " +(coins);
        
    }


}
