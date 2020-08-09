using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
	public Transform destination;

  

	void OnTriggerEnter(Collider Col)
	{
		Col.transform.position = destination.transform.position;
	}



}
