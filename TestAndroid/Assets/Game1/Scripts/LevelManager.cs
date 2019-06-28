using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Button[] levelButton;
    public static LevelManager instanceLevel;

    private void Start()
    {
        //locking levels other than then first level or unlocked levels
        for (int i = 0; i < levelButton.Length; i++)
        {
            for (int j = 1; j < levelButton.Length; j++)
            {
                if (i == 0 || j == (PlayerPrefs.GetInt("UnlockedLevel") - 1))
                {
                    levelButton[i].interactable = true;
                    levelButton[j].interactable = true;
                }
                else
                    levelButton[i].interactable = false;
                Debug.Log(i);

            }
        }
       
    }

    public void LoadLevels(int levelNum)
    {        
        Application.LoadLevel(levelNum);
        PlayerPrefs.SetInt("SelectedLevel", levelNum);
    }

       
}
