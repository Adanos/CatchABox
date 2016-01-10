﻿using Assets.Scripts.model;
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
			this.model = GameObject.FindObjectOfType<GiftModel>();
			this.wind = GameObject.FindObjectOfType<Wind>();
			view = new VeryBigGiftView();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}
	}
}
