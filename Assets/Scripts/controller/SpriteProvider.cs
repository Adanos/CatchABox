using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class SpriteProvider : Singleton<SpriteProvider>
	{
		string pathToSpritesVeryBig = "Sprites/prezenty/bardzoDuze/";
		string pathToSpritesBig = "Sprites/prezenty/duze/";
		string pathToSpritesSmall = "Sprites/prezenty/male/";
		string pathToSpritesVerySmall = "Sprites/prezenty/bardzoMale/";

		Sprite[] spritesVeryBig;
		Sprite[] spritesBig;
		Sprite[] spritesSmall;
		Sprite[] spritesVerySmall;

		//StreamWriter streamWriter;

		public void initialize() // możesz zawołać z Awake jeśli chcesz 
		{
			//streamWriter = new StreamWriter(@"C:\tekstury_rozmiary.txt");

			spritesVeryBig = loadTexturesToArray(pathToSpritesVeryBig);
			spritesBig = loadTexturesToArray(pathToSpritesBig);
			spritesSmall = loadTexturesToArray(pathToSpritesSmall);
			spritesVerySmall = loadTexturesToArray(pathToSpritesVerySmall);

			//streamWriter.Close();
		}

		private Sprite[] loadTexturesToArray(string path)
		{
			Texture2D[] textures = Resources.LoadAll<Texture2D>(path);

			//foreach (Texture2D texture in textures)
				//streamWriter.WriteLine(new StringBuilder(texture.name).AppendFormat(" {0} x {1}", texture.width, texture.height));

			return textures.Select(texture => Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero)).ToArray();
		}

		public Sprite getRandomSpriteVeryBig()
		{
			if (spritesVeryBig == null)
				initialize();
			return spritesVeryBig[UnityEngine.Random.Range(0, spritesVeryBig.Length - 1)];
		}

		public Sprite getRandomSpriteBig()
		{
			if (spritesBig == null)
				initialize();
			return spritesBig[UnityEngine.Random.Range(0, spritesBig.Length - 1)];
		}

		public Sprite getRandomSpriteSmall()
		{
			if (spritesSmall == null)
				initialize();
			return spritesSmall[UnityEngine.Random.Range(0, spritesSmall.Length - 1)];
		}

		public Sprite getRandomSpriteVerySmall()
		{
			if (spritesVerySmall == null)
				initialize();
			return spritesVerySmall[UnityEngine.Random.Range(0, spritesVerySmall.Length - 1)];
		} 
	}
}
