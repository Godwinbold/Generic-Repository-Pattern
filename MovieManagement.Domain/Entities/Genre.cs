﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
	public class Genre
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<Movie>? Movies { get; set; }
	}
}
