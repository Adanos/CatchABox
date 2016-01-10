using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class BigGiftController : GiftController
	{
		void Start()
		{
			model = GameObject.FindObjectOfType<GiftModel>();
			view = new BigGiftView();
			wind = GameObject.FindObjectOfType<Wind>();
			spawner = GameObject.FindObjectOfType<Spawner>();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}
	}
}
