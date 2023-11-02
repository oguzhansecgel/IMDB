using DataAccessLayer.Mapping;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext 
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-3QG9GTV;initial catalog = IMDB; integrated security=true");
		}

		public DbSet<Film> Films { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Director> Directors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new FilmMapping<Film>());
			modelBuilder.ApplyConfiguration(new DirectorMapping<Director>());
			modelBuilder.ApplyConfiguration(new CategoryMapping<Category>());
		}

	}

}
