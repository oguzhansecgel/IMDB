using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
	public class FilmMapping<T> : IEntityTypeConfiguration<T> where T : Film
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.FilmId).
				HasColumnName("FILM_ID").
				HasColumnOrder(1);

			builder.Property(x => x.FilmName).
				HasColumnName("FILM_ADI").
				HasColumnOrder(2).
				HasColumnType("nvarchar(100)");

			builder.Property(x=>x.FilmDescription).
				HasColumnName("FILM_ACIKLAMASI").
				HasColumnOrder(3).
				HasColumnType("nvarchar(255)");
			builder.Property(x => x.FilmYear).
				HasColumnName("FILM_CIKIS_SENESİ").
				HasColumnOrder(4);
			builder.HasData(new Film { FilmId = 1, FilmName = "Recep İvedik 1 ", FilmDescription = "Deneme Deneme Deneme Deneme", FilmYear = 2008, CategoryId = 2, DirectorId = 1 });
 
				
		}
	}
}
