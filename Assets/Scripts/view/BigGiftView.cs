using Assets.Scripts.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.view
{
	class BigGiftView : GiftView
	{
		public BigGiftView()
		{
			spriteProvider = SpriteProvider.Instance;
			sprite = spriteProvider.getRandomSpriteBig();
		}
	}
}
