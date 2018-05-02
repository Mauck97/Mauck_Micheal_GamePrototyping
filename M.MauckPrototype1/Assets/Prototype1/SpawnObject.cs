using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject RockPrefab;


	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnRock());

	}
	
	// Update is called once per frame
	void Update () {


	}

    IEnumerator SpawnRock()
    {
        Instantiate(RockPrefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(3);

        StartCoroutine(SpawnRock());
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            Destroy(gameObject);
        }


    }





}
