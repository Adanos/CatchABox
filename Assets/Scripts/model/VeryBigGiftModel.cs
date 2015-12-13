using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.model
{
	class VeryBigGiftModel: GiftModel
	{
		private const float VELOCITY = -0.04f;

		public VeryBigGiftModel()
		{
			setVelocity(VELOCITY);
		}
	}
}
