﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {

	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public Text timerText;
	public string sceneName;
	public float startTime;
	public Scene currentScene;
	// Use this for initialization
	void Start () {
		currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
		//Time.time is the amount of time that the application has been running
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time-startTime;
		string minutes = ((int) t / 60).ToString();
		string seconds = (t % 60).ToString("f2");
		if (timerText != null)
		{
			timerText.text = minutes + ":" + seconds;
		}
		sceneName = currentScene.name;
		if (sceneName == "Level 0")
		{
			if (t > 45)
			{
				star1.SetActive(false);
				star2.SetActive(false);
				star3.SetActive(false);
			}
			else if (t > 30)
			{
				star1.SetActive(false);
				star2.SetActive(false);
				star3.SetActive(true);
			}
			else if (t > 15)
			{
				star1.SetActive(false);
				star2.SetActive(true);
				star3.SetActive(true);
			}
			else
			{
				star1.SetActive(true);
				star2.SetActive(true);
				star3.SetActive(true);
			}
		}
		else if (sceneName == "Level 1")
		{
			if (t > 45)
			{
				star1.SetActive(false);
				star2.SetActive(false);
				star3.SetActive(false);
			}
			else if (t > 30)
			{
				star1.SetActive(false);
				star2.SetActive(false);
				star3.SetActive(true);
			}
			else if (t > 15)
			{
				star1.SetActive(false);
				star2.SetActive(true);
				star3.SetActive(true);
			}
			else
			{
				star1.SetActive(true);
				star2.SetActive(true);
				star3.SetActive(true);
			}
		}
	}
}
