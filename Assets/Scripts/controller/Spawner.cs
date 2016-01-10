using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.model;

namespace Assets.Scripts.controller
{
	public class Spawner : MonoBehaviour
	{
		public List<GameObject> gifts;// { get; private set; }
		public GameObject[] groupsClouds;
		private int delay = 0;

		// Use this for initialization
		void Start()
		{
			gifts = new List<GameObject>();
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
			gifts.Add((GameObject)Instantiate(groupsClouds[i], transform.position, Quaternion.identity));
		}
	}
}
