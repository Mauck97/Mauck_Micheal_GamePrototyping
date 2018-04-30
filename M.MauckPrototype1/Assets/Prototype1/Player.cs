using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D Rigid;
    public float JumpForce;
    public int JumpForceInt;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            

        }

        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
           
            

        }

    }
}
