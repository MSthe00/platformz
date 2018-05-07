using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour {

    static double time; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        this.GetComponent<Text>().text = time.ToString("N2");
        
	}
}
