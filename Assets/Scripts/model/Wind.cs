using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.model
{
	enum Directions { Left, Right}

	class Wind: MonoBehaviour
	{
		private int delay = 0;
		public const float MOVEMENT = 0.01f;
		public Directions direction { get; set; }

		void Start()
		{
			direction = Directions.Left;
		}

		void Update()
		{
			if (delay > 100)
			{
				delay = 0;
				randomDirection();
			}

			delay++;
		}

		void randomDirection()
		{
			int i = UnityEngine.Random.Range(0, 2);

			direction = (i % 2 == 0) ? Directions.Left : Directions.Right;
		}

		public float getMovement()
		{
			return (direction == Directions.Left) ? -MOVEMENT : MOVEMENT;
		}
	}
}
