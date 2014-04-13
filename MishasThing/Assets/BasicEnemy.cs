using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {

	public GameObject prfbWallEnemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "BasicEnemy"){
			Instantiate(prfbWallEnemy, transform.position, Quaternion.identity);
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
		}
		
	}
}
