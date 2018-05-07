using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startthegame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void ButtonClick()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
