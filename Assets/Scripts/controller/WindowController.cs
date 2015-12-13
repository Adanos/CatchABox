using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class WindowController: MonoBehaviour
	{
		private WindowModel model { get; set; }
		private WindowView view { get; set; }
		private SpriteRenderer sprite;

		void Start()
		{
			this.model = GameObject.FindObjectOfType<WindowModel>();
			this.view = GameObject.FindObjectOfType<WindowView>();
			sprite = GameObject.FindObjectsOfType<SpriteRenderer>().First(x => x.name == "window_1_1");
		}

		void Update()
		{
			if (model.isActivate)
				turnOffLights();
			else turnOnLights();
		}

		public void turnOnLights()
		{
			model.isActivate = true;
			sprite.sortingOrder = 4;
			
			//Debug.Log("wlaczony " + sprite.ToString());
		}

		public void turnOffLights()
		{
			model.isActivate = false;
			sprite.sortingOrder = 0;
			//Debug.Log("wylaczony");
		}
	}
}
