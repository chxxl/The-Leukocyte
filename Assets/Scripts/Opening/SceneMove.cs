﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour {

    
	public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
