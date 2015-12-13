using Assets.Scripts.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class HouseController : MonoBehaviour
	{
		private int numberGifts;
		private ChimneyController chimney;
		private WindowController window;

		void Start()
		{
			this.chimney = GameObject.FindObjectOfType<ChimneyController>();
			this.window = GameObject.FindObjectOfType<WindowController>();
		}
	}
}
