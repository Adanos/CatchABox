using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class BoardController: MonoBehaviour
	{
		public static float leftXPositionOfBoard { get; private set; }
		public static float rightXPositionOfBoard { get; private set; }

		void Start()
		{
			SpriteRenderer sprite = GameObject.FindObjectOfType<BoardController>().GetComponent<SpriteRenderer>();

			leftXPositionOfBoard = sprite.bounds.min.x;
			rightXPositionOfBoard = sprite.bounds.max.x;
		}

		void Update()
		{
		}
	}
}
