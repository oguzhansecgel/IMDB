using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
	public class DirectorMapping<T> : IEntityTypeConfiguration<T> where T : Director
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.DirectorID).
				HasColumnName("YONETMEN_ID").
				HasColumnOrder(1);

			builder.Property(x => x.DirectorName).
				HasColumnName("YONETMEN_ADI").
				HasColumnOrder(2).
				HasColumnType("nvarchar(50)");

			builder.Property(x => x.DirectorSurname).
				HasColumnName("YONETMEN_SOYADI").
				HasColumnOrder(3).
				HasColumnType("nvarchar(50)");
			builder.HasData(new Director { DirectorID = 1, DirectorName = "Şahan", DirectorSurname = "Gökbahar" });
 
		}
	}
}
