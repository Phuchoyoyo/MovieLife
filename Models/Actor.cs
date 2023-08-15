using System;
using System.ComponentModel.DataAnnotations;

namespace MovieLife.Models
{
	public class Actor
	{
		[Key]

		public int Id { get; set; }

		public string ProfilePictureUrl { get; set; }

		public string FullName { get; set; }

		public string Bio { get; set; }

		//relatioships

		public List<Actor_Movie> Actors_Movies { get; set; }

	}
}

