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
	public class SeriesMapping<T> : IEntityTypeConfiguration<T> where T : Series
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.SeriesId).
				HasColumnName("DIZI_ID").
				HasColumnOrder(1);

			builder.Property(x=>x.SeriesName).
				HasColumnName("DIZI_ADI").
				HasColumnOrder(2);
			builder.Property(x => x.SeriesYear).
				HasColumnName("DIZI_YILI").
				HasColumnOrder(4);
			builder.Property(x => x.SeriesDescription).
				HasColumnName("DIZI_ACIKLAMASI").
				HasColumnOrder(3);
			 
		}
	}
}
