using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public GameObject PopUp;

   
    public void pauseGame()
    {
        PopUp.SetActive(true);
        
    }
    public void continueGame()
    {
        PopUp.SetActive(false);
       
    }

    //public void RestartGame()
    //{
    //    //mainmenu
    //    Application.LoadLevel(0); 
    //    //
    //}

    public void NextButtonClickEvent()
    {
        Application.LoadLevel("LevelsPage");

    }

    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }

    public void exitGame()
    {
        Application.Quit();
    }

   
}
