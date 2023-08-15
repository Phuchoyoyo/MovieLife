﻿using System;
using System.ComponentModel.DataAnnotations;


namespace MovieLife.Models
{
	public class Cinemas
	{
		[Key]

		public int Id { get; set; }

		public string Logo { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		//relationships

		public List<Movie> Movies { get; set; }
	}
}

