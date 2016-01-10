using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class VeryBigGiftController : GiftController
	{
		void Start()
		{
			model = GameObject.FindObjectOfType<GiftModel>();
			view = new VeryBigGiftView();
			wind = GameObject.FindObjectOfType<Wind>();
			spawner = GameObject.FindObjectOfType<Spawner>();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}
	}
}
