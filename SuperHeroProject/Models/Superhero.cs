﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroProject.Models
{
	public class Superhero
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string AlterEgo { get; set; }
		public string SuperheroAbility { get; set; }
		public string SecondSuperheroAbility { get; set; }
		public string Catchphrase { get; set; }
	}
}