using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public static GameObject PrfbBasicEnemy;
	public static GameObject PrfbWallEnemy;
	public static GameObject prfbRunningEnemy;
	public static GameObject prfbShootingEnemy;
	// Use this for initialization
	void Start () {
		PrfbBasicEnemy = (GameObject)Resources.Load ("Prefabs/BasicEnemy");
		PrfbWallEnemy = (GameObject)Resources.Load ("Prefabs/WallEnemy");
		prfbRunningEnemy = (GameObject)Resources.Load ("Prefabs/RunningGuy");
		prfbShootingEnemy = (GameObject)Resources.Load ("Prefabs/ShootyGuy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
