﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NC_MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Exitbutton()
    {
        Application.Quit();
    }

    public void SceneSelect(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
