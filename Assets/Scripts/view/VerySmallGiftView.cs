using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.view
{
	class VerySmallGiftView : GiftView
	{
		public VerySmallGiftView()
		{
			spriteProvider = SpriteProvider.Instance;
			sprite = spriteProvider.getRandomSpriteVerySmall();
		}
	}
}
