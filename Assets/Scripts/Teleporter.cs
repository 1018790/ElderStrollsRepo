using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
	public Transform destination;

  

	void OnTriggerEnter(Collider col)
	{
		col.transform.position = destination.transform.position;
	}



}
