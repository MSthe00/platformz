using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerLogic : MonoBehaviour {

    static double time;
    public Text endscore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(SceneManager.GetActiveScene().name == "Endscreen")
        {
            this.GetComponent<Text>().text = time.ToString("N2");
            endscore.text = time.ToString("N2");
          
        }
        else if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            time = 0;
        }
        else
        {

            time += Time.deltaTime;
            this.GetComponent<Text>().text = time.ToString("N2");
        }

        
	}
}
