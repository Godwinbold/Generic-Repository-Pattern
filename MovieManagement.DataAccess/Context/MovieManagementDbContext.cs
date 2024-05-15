using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
	public class MovieManagementDbContext : DbContext
	{
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext>options): base(options) { }


        public DbSet<Actor> Actors { get; set; }
		public DbSet<Biography> Biographies { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Actor>().HasData(
				new Actor { Id=1, FirstName="Godwin", LastName="Ozioko",},
				new Actor { Id = 2, FirstName = "Francis", LastName = "Ekweme", },
                new Actor { Id = 3, FirstName = "John", LastName = "Doe" }
				);
			modelBuilder.Entity<Movie>().HasData(
				new Movie { Id =1, Name="Matrix", Description = "Box office we coming", ActorId =1},
				new Movie { Id = 2, Name = "Love and Basketball", Description = "Romance and Chill", ActorId = 2 },
				new Movie { Id = 3, Name = "SpiderMan", Description = "Sky Scrapers", ActorId = 1 },
				new Movie { Id = 4, Name = "Wakanda Forever", Description = "The True Kingdom", ActorId = 3 }
				);
		}

	}


}
