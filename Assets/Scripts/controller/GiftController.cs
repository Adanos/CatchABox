using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	abstract class GiftController : MonoBehaviour
	{
		protected GiftModel model { get; set; }
		protected GiftView view { get; set; }
		protected Wind wind { get; set; }
		protected Spawner spawner;

		protected void setBoxCollider()
		{
			SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			Vector3 boundsOfRenderer = renderer.bounds.size;
			BoxCollider2D boxCollider2d = GetComponent<BoxCollider2D>();

			boxCollider2d.size = boundsOfRenderer;
			boxCollider2d.offset = boxCollider2d.size/2;
		}

		public void move(float x, float y)
		{
			model.setX(model.x + x);
			model.setY(model.y + y);
		}

		public void setVelocity(float velocity)
		{
			model.setVelocity(velocity);
		}

		void Start()
		{
		}

		void OnMouseDown()
		{
			//Debug.Log("jest " + id);
			model.setClicked(true);
		}

		void OnMouseUp()
		{
			model.setClicked(false);
		}

		void OnMouseDrag()
		{
			float distanceToScreen = Camera.main.WorldToScreenPoint(transform.position).z;
			Vector3 positionMove = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToScreen));
			model.setX(positionMove.x);
			model.setY(model.y + model.velocity);
		}

		void Update()
		{
			if (checkPossibilityRemoveGift())
				removeGift();

			if (model != null && !model.isClicked)
				move(wind.getMovement(), model.velocity);
		}

		private void removeGift()
		{
			GameObject currentGameObject = spawner.gifts.Find(x => x == gameObject);
			spawner.gifts.Remove(gameObject);

			Destroy(currentGameObject);
		}

		private bool checkPossibilityRemoveGift()
		{
			if (model.x > BoardController.rightXPositionOfBoard || model.x < BoardController.leftXPositionOfBoard)
			{
				return true;
			}

			return false;
		}
	}
}
