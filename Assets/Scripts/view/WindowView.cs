using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.view
{
	class WindowView: MonoBehaviour
	{
		private static string path = "Assets/Sprites/okna/etap_";
		private Texture2D texture;

		public WindowView(string name, int stage)
		{
			//texture = (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath(path + name, typeof(Texture2D));
			string fullpath = path + stage + "/" + name;
			texture = (Texture2D)Resources.Load(fullpath);
			texture.Apply();
			//texture.height = 100;
			//texture.width = 100;
		}
	}
}
