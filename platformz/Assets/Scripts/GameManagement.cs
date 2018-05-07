using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    public GameObject Leveldone;
    public GameObject Levelfail;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GameWin()
    {
        Leveldone.SetActive(true);
        Invoke("StartNext", 1);
    }

    public void GameLose()
    {
        Levelfail.SetActive(true);
        Invoke("Restart", 1);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void StartNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
