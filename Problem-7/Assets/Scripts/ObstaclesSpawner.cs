using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
	public Transform[] Pos;
	public GameObject Obj;

	public Transform Loc;

	public bool ToSpawn = true;

	// Start is called before the first frame update
	void Update()
	{
		Loc = Pos[Random.Range(0, Pos.Length)];

		if (ToSpawn == true)
		{
			Instantiate(Obj, Loc);
			ToSpawn = false;
			// StartCoroutine(ToSpawnTrue());
		}
	}

	// IEnumerator ToSpawnTrue()
	// {
	// 	yield return new WaitForSeconds(0.75f);
	// 	ToSpawn = true;
	// }
}