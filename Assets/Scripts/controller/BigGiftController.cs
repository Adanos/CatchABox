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
			this.model = GameObject.FindObjectOfType<GiftModel>();
			this.wind = GameObject.FindObjectOfType<Wind>();
			view = new BigGiftView();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}
	}
}
