﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour {

	public Canvas QuitMenu;
	public Button StartText;
	public Button ExitText;

	// Use this for initialization
	void Start () {
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		StartText = StartText.GetComponent<Button> ();
		ExitText = ExitText.GetComponent<Button> ();
		QuitMenu.enabled = false;
		
	}
	
	public void ExitPress()
	{
		QuitMenu.enabled = true;
		StartText.enabled = false;
		ExitText.enabled = false;
	}
	
	public void NoPress()
	{
		QuitMenu.enabled = false;
		StartText.enabled = true;
		ExitText.enabled = true;
	}
	
	public void StartLevel()
	{
		Application.LoadLevel (1);
	}
	
	public void Menu()
	{
		//Application.LoadLevel(0);
		Application.LoadLevel("StartGame");
	}
	
	public void ExitGame()
	{
		Application.Quit ();
	}
}
