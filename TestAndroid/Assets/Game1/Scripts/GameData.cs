using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameData : MonoBehaviour {
    
    public Text scoreText;
    public GameObject pausePopUp;
    int score;
    public float timer;

    public Text coinText;
    int coins;
    int unlockedLevelIndex;
    public Text levelName;

    public GameObject gameWinPopUP, gameOverPopUp;

    

    // Use this for initialization
    void Start()
    {
        score = 0;
        timer = 0.0f;

        //Cursor.visible = false;
        coins = 8;
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
        else if (other.GetComponent<Collider>().tag == "Enemy")
                   gameOverPopUp.SetActive(true);

        //levelcomplete condition
        if (coins == 10)
        {
            PlayerPrefs.SetInt("LevelComplete", 1);
            // unlock the next level
            if (PlayerPrefs.GetInt("LevelComplete") == 1)
            {
                unlockedLevelIndex = PlayerPrefs.GetInt("SelectedLevel") + 1;
                PlayerPrefs.SetInt("UnlockedLevel", unlockedLevelIndex);

                Debug.Log(PlayerPrefs.GetInt("UnlockLevel"));
            }
            //Application.LoadLevel(5);//gamewin
            gameWinPopUP.SetActive(true);
           


        }
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Rewards: " + (coins);

        if (pausePopUp.activeInHierarchy || gameWinPopUP.activeInHierarchy || gameOverPopUp.activeInHierarchy)
            Time.timeScale = 0.0f;
        else
        {
            Time.timeScale = 1.0f;
            timer = Time.deltaTime * 0.01f;
            if (timer > 0)
            {
                score += 1;
                scoreText.text = "Score: " + score;
            }
        }


    }

}
