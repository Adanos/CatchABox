using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.model
{
	abstract class GiftModel : MonoBehaviour
	{
		private bool isVisible;
		//protected Texture2D[] textures;
		public bool isClicked { get; private set; }
		public float velocity { get; private set; }
		public float x { get; private set; }
		public float y { get; private set; }

		public GiftModel()
		{
			x = 0;
			y = 4;
			velocity = -0.01f;
		}

		public void setX(float x)
		{
			this.x = x;
			//transform.position = new Vector3(x, y, -1);
		}

		public void setY(float y)
		{
			this.y = y;
			transform.position = new Vector3(x, y, -1);
		}

		public void setVelocity(float velocity)
		{
			this.velocity = velocity;
		}

		public void setClicked(bool isClicked)
		{ 
			this.isClicked = isClicked;
		}
	}
}
