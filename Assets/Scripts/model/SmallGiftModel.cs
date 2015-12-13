using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.model
{
	class SmallGiftModel: GiftModel
	{
		private const float VELOCITY = -0.02f;

		public SmallGiftModel()
		{
			setVelocity(VELOCITY);
		}
	}
}
