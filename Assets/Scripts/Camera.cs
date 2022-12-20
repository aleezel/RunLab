using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public Player PosicionPlayer;
	Vector3 SiguientePosicion;

	float DistanciaMover;

	// Use this for initialization
	void Start()
	{
		PosicionPlayer = FindObjectOfType<Player>();
		SiguientePosicion = PosicionPlayer.transform.position;

	}

	// Update is called once per frame
	void Update()
	{

		DistanciaMover = PosicionPlayer.transform.position.x - SiguientePosicion.x;
		transform.position = new Vector3(transform.position.x + DistanciaMover, transform.position.y, transform.position.z);
		SiguientePosicion = PosicionPlayer.transform.position;


	}

}
