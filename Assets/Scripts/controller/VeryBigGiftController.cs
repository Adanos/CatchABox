using Assets.Scripts.model;
using Assets.Scripts.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	class VeryBigGiftController : GiftController
	{
		void Start()
		{
			this.model = GameObject.FindObjectOfType<GiftModel>();
			this.wind = GameObject.FindObjectOfType<Wind>();
			view = new VeryBigGiftView();
			gameObject.GetComponent<SpriteRenderer>().sprite = view.sprite;
			setBoxCollider();
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				RaycastHit hitInfo = new RaycastHit();
				bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
				if (hit)
				{
					model.setClicked(true);
					//Debug.Log("Hit " + hitInfo.transform.gameObject.name);
					if (hitInfo.transform.gameObject.tag == "Construction")
					{
						//	Debug.Log("It's working!");
					}
					else
					{
						//	Debug.Log("nopz");
					}
				}
				else
				{
					//	Debug.Log("No hit");
				}
				//Debug.Log("Mouse is down");
			}

			if (model != null && !model.isClicked)
				move(wind.getMovement(), model.velocity);
			//Debug.Log("przesuwam" + model.y);
		}
	}
}
