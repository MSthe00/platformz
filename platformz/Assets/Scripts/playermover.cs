using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playermover : MonoBehaviour {
    public float speed;
    public float jumpspeed;
    public Transform player;
    private float jumpcount;
    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "level")
        {
            jumpcount = 0;
        }

        if (collisionInfo.gameObject.tag == "Respawn")
        {
            FindObjectOfType<GameManagement>().GameLose();
        }

        if (collisionInfo.gameObject.tag == "Finish")
        {
            FindObjectOfType<GameManagement>().GameWin();
            this.GetComponent<Rigidbody>().isKinematic = true;
            
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void FixedUpdate () {
		if(Input.GetKey("d"))
        {
            this.GetComponent<Rigidbody>().AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            this.GetComponent<Rigidbody>().AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            this.GetComponent<Rigidbody>().AddForce(0,0,speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space) && jumpcount < 1)
        {
            this.GetComponent<Rigidbody>().AddForce(0, jumpspeed * Time.deltaTime, 0);
            jumpcount++;
        }

    }
}
