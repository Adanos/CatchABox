using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.view
{
	class SmallGiftView : GiftView
	{
		public SmallGiftView()
		{
			spriteProvider = SpriteProvider.Instance;
			sprite = spriteProvider.getRandomSpriteSmall();
		}
	}
}
