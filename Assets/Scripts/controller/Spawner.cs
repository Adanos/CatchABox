using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.model;

namespace Assets.Scripts.controller
{
	public class Spawner : MonoBehaviour
	{
		private int delay = 0;
		public GameObject[] groupsClouds;

		// Use this for initialization
		void Start()
		{
			spawnNext();
		}

		// Update is called once per frame
		void Update()
		{
			if (delay > 100)
			{
				delay = 0;
				spawnNext();
			}

			delay++;
		}

		public void spawnNext()
		{
			// Random Index
			int i = Random.Range(0, groupsClouds.Length);

			// Spawn Group at current Position
			Instantiate(groupsClouds[i], transform.position, Quaternion.identity);
		}
	}
}
