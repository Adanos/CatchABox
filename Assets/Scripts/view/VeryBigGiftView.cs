using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.view
{
	class VeryBigGiftView : GiftView
	{
		public VeryBigGiftView()
		{
			spriteProvider = SpriteProvider.Instance;
			sprite = spriteProvider.getRandomSpriteVeryBig();
		}
	}
}
