using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
	public class CategoryMapping<T> : IEntityTypeConfiguration<T> where T : Category
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.CategoryId).
				HasColumnName("KATEGORI_ID").
				HasColumnOrder(1);

			builder.Property(x => x.CategoryName).
				HasColumnName("KATEGORI_ADI").
				HasColumnOrder(2).
				HasColumnType("nvarchar(50)");

			builder.HasData(new Category { CategoryId = 1, CategoryName = "Aksiyon" },
							new Category { CategoryId = 2, CategoryName = "Komedi" },
							new Category { CategoryId = 3, CategoryName = "Romantik" },
							new Category { CategoryId = 4, CategoryName = "Korku" });

		}
	}
}
