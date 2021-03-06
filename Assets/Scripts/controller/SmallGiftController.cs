﻿using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class SmallGiftController : GiftController
	{
		void Start()
		{
			model = GameObject.FindObjectOfType<GiftModel>();
			view = new SmallGiftView();
			wind = GameObject.FindObjectOfType<Wind>();
			spawner = GameObject.FindObjectOfType<Spawner>();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}
	}
}
