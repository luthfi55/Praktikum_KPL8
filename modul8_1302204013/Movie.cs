﻿using System;
namespace modul8_1302204013
{
	public class Movie
	{
			public int id { get; set; } = 0;
			public string Title { get; set; } = "";
			public string Director { get; set; } = "";
			public List<string> Stars { get; set; }
			public string Description { get; set; } = "";
	}
}