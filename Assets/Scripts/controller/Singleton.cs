using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.controller
{
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static readonly object syncLock = new object();
		private static T instance;

		protected Singleton()
		{
		}

		public static T Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncLock)
					{
						if (instance == null)
						{
							//instance = new T();
							instance = new GameObject(typeof (T).Name).AddComponent<T>(); 
						}
					}
				}

				return instance;
			}
		}
	}
}
