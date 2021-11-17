﻿using System;
using UnityEngine;

public class Readmes : ScriptableObject {
	public Texture2D icon;
	public string title;
	public Section[] sections;
	public bool loadedLayout;
	
	public class Section {
		public string heading, text, linkText, url;
	}
}
