using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void pauseGame()
    {
        GameData.instance.pausePopUp.SetActive(true);
        
    }
    public void continueGame()
    {
        GameData.instance.pausePopUp.SetActive(false);
       
    }

    public void RestartLevel()
    {
       SceneManager.LoadScene(PlayerPrefs.GetInt("SelectedLevel"));        
    }

    public void NextButtonClickEvent()
    {
        SceneManager.LoadScene("LevelsPage");

    }

    public void ChangeToScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void exitGame()
    {
        Application.Quit();
    }

   
}
